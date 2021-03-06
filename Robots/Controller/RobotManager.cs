﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Robots.Log;
using Robots.Model;
using Robots.View;

namespace Robots.Controller
{
    /// <summary>
    /// Robot manager.
    /// </summary>
    public class RobotManager : IDisposable
    {
        private readonly int coreNumber = 0;
        
        private readonly BlockingCollection<IElement> elements = new BlockingCollection<IElement>(new ConcurrentQueue<IElement>());

        private readonly ConcurrentQueue<IRobot> robots = new ConcurrentQueue<IRobot>();

        private readonly ConcurrentQueue<IElement> warehouse = new ConcurrentQueue<IElement>();

        private readonly List<Task> tasks = new List<Task>();

        private readonly List<IElement> records = new List<IElement>();

        private CountdownEvent taskSignal;

        private System.Timers.Timer timer;

        private Stopwatch stopWatch;

        private bool disposedValue;

        private event EventHandler<IElement> EnqueueIdleElement;

        public RobotManager(int redRobots, int greenRobots, int blueRobots, int numberOfElements)
        {
            this.Logger = new /*ConsoleLogger*/NullLogger();

            this.NumberOfElements = numberOfElements;
            this.NumberOfRedRobots = redRobots;
            this.NumberOfGreenRobots = greenRobots;
            this.NumberOfBlueRobots = blueRobots;
            this.coreNumber = redRobots + greenRobots + blueRobots;

            this.EnqueueIdleElement += this.RobotManager_EnqueueIdleElement;
            
            // Distribute robots equally
            int max = Math.Max(redRobots, Math.Max(greenRobots, blueRobots));
            for (int i = 1; i <= max; i++)
            {
                if (i <= redRobots)
                {
                    this.robots.Enqueue(new RobotRed(i, 1) { Logger = this.Logger });
                }
                if (i <= greenRobots)
                {
                    this.robots.Enqueue(new RobotGreen(i, 1) { Logger = this.Logger });
                }
                if (i <= blueRobots)
                {
                    this.robots.Enqueue(new RobotBlue(i, 1) { Logger = this.Logger });
                }
            }

            this.CreateElements(numberOfElements);
        }

        public ILogger Logger { get; set; }

        public int NumberOfElements { get; private set; }

        public int NumberOfRedRobots { get; private set; }

        public int NumberOfGreenRobots { get; private set; }

        public int NumberOfBlueRobots { get; private set; }

        /// <summary>
        /// Sets job duration interval for the red robots.
        /// </summary>
        public int IntervalRed
        {
            set
            {
                if (value < 0)
                {
                    return;
                }

                foreach (var robot in robots)
                {
                    if ((robot as RobotRed) != null)
                    {
                        robot.Interval = value;
                    }
                }
            }
        }

        /// <summary>
        /// Sets job duration interval for the green robots.
        /// </summary>
        public int IntervalGreen
        {
            set
            {
                if (value < 0)
                {
                    return;
                }

                foreach (var robot in robots)
                {
                    if ((robot as RobotGreen) != null)
                    {
                        robot.Interval = value;
                    }
                }
            }
        }

        /// <summary>
        /// Sets job duration interval for the blue robots.
        /// </summary>
        public int IntervalBlue
        {
            set
            {
                if (value < 0)
                {
                    return;
                }

                foreach (var robot in robots)
                {
                    if ((robot as RobotBlue) != null)
                    {
                        robot.Interval = value;
                    }
                }
            }
        }

        /// <summary>
        /// Current process duration.
        /// </summary>
        public int ElapsedMilliseconds => (int) (stopWatch?.ElapsedMilliseconds ?? 0);

        /// <summary>
        /// Get the number of finished elements.
        /// </summary>
        private int WarehouseCount => warehouse.Count;

        /// <summary>
        /// Feed the grid.
        /// </summary>
        public List<IElement> Records => this.records;

        private void CreateElements(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                var element = new Element(i);
                this.AddElement(element);
                this.records.Add(element);
            }
        }

        /// <summary>
        /// Add element to processing queue.
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        /// <summary>
        /// Add finished element to warehouse storage.
        /// </summary>
        /// <param name="element"></param>
        public void AddElementToWarehouse(IElement element)
        {
            this.warehouse.Enqueue(element);
        }

        /// <summary>
        /// Stop only if all elements are painted and stored in the warehouse.
        /// </summary>
        /// <returns></returns>
        private bool TryInternalStop()
        {
            if (this.warehouse.Count == this.NumberOfElements)
            {
                this.Stop();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Clear any remaining elements from the queue.
        /// </summary>
        private void ClearBlockingCollection()
        {
            while (elements.TryTake(out _));
        }

        /// <summary>
        /// Start processing elements by robots.
        /// </summary>
        public void Start()
        {
            this.stopWatch = Stopwatch.StartNew();

            //Task.Run(() => this.CreateElements(this.numberOfElements));

            this.timer = new System.Timers.Timer(100);
            this.timer.Elapsed += Timer_Elapsed;
            this.timer.AutoReset = true;
            this.timer.Enabled = true;

            this.taskSignal = new CountdownEvent(this.coreNumber);

            for (int i = 0; i < this.coreNumber; i++)
            {
                tasks.Add(Task.Factory.StartNew(RunRobotSheduler, TaskCreationOptions.LongRunning)/*.ContinueWith(t => ReportStatus())*/);
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.TryInternalStop();
        }

        /// <summary>
        /// Query the elements queue to process unfinished elements.
        /// </summary>
        private void RunRobotSheduler()
        {
            try
            {
                foreach (var item in elements.GetConsumingEnumerable())
                {
                    ProcessElement(item);
                }
            }
            catch (PaintException pex)
            {
                Logger.Error($"Paint error => {pex.Message}");
            }
            catch (Exception ex)
            {
                Logger.Error($"Robot error => {ex.Message}");
            }
            finally
            {
                this.taskSignal.Signal();
            }
        }

        /// <summary>
        /// Run robots jobs.
        /// </summary>
        /// <param name="element"></param>
        private void ProcessElement(IElement element)
        {           
            foreach (var robot in robots)
            {
                if (!robot.Busy)
                {
                    var duration = Stopwatch.StartNew();
                    robot.Paint(element);
                    robot.AddExecutionTime((int)duration.ElapsedMilliseconds);
                }

                element.FinishUp();

                if (element.IsComplete)
                {
                    break;
                }
            }

            if (element.IsComplete)
            {
                ElementCompleted(element);
            }
            else
            {
                ElementIdle(element);
            }
        }

        /// <summary>
        /// Add fihished element to the warehouse storage.
        /// </summary>
        /// <param name="element"></param>
        private void ElementCompleted(IElement element)
        {
            this.AddElementToWarehouse(element);
            Logger.TextColor = ConsoleColor.Cyan;
            Logger.Info($"Completed, transfering Element({(element as Element)?.Id}) to the warehouse.");
        }

        /// <summary>
        /// Add element again to the processing queue.
        /// </summary>
        /// <param name="element"></param>
        private void ElementIdle(IElement element)
        {
            var handler = this.EnqueueIdleElement;
            handler?.Invoke(this, element);
            Logger.TextColor = ConsoleColor.DarkMagenta;
            Logger.Info($"Idle, returning Element({(element as Element)?.Id}) to the pool.");
        }

        private void RobotManager_EnqueueIdleElement(object sender, IElement element)
        {
            this.AddElement(element);
        }

        /// <summary>
        /// Stop processing.
        /// </summary>
        public void Stop()
        {
            this.timer.Enabled =  false;

            this.elements.CompleteAdding();
            
            foreach(var robot in robots)
            {
                robot.Abort = true;
            }

            this.stopWatch.Stop();
        }

        public void ReportStatus()
        {
            Logger.TextColor = ConsoleColor.White;
            Logger.Info($"Finished job in {this.ElapsedMilliseconds}ms");
            Logger.Info($"Total elements in warehouse: {warehouse.Count}");
        }

        /// <summary>
        /// Get statistics.
        /// </summary>
        /// <returns>View object representing the required statistics.</returns>
        public Statistics Statistics()
        {
            int[] processed = new int[3];
            int[] busy = new int[3];
            int[] totalTime = new int[3];
            foreach (var robot in robots)
            {
                if ((robot as RobotRed) != null)
                {
                    processed[0] += robot.Completed;
                    busy[0] += robot.Busy ? 1 : 0;
                    totalTime[0] += robot.ProcessingTime;
                }
                else if ((robot as RobotGreen) != null)
                {
                    processed[1] += robot.Completed;
                    busy[1] += robot.Busy ? 1 : 0;
                    totalTime[1] += robot.ProcessingTime;
                }
                else if ((robot as RobotBlue) != null)
                {
                    processed[2] += robot.Completed;
                    busy[2] += robot.Busy ? 1 : 0;
                    totalTime[2] += robot.ProcessingTime;
                }
            }

            var elementStatistics = new ElementStatistics(this.NumberOfElements, this.WarehouseCount, processed[0], processed[1], processed[2]);
            var robotStatistics = new RobotStatistics(busy[0], busy[1], busy[2], totalTime[0], totalTime[1], totalTime[2]);
            return new Statistics(elementStatistics, robotStatistics);
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    this.Stop();
                    this.warehouse.Clear();
                    this.robots.Clear();
                    this.tasks.Clear();
                    ClearBlockingCollection();
                    this.timer?.Dispose();
                    // Check if all the tasks are fihished
                    this.taskSignal.Wait();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RobotManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
