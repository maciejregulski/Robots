using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
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

        private readonly List<IElement> records = new List<IElement>();

        private Stopwatch stopWatch;

        private bool disposedValue;

        private event EventHandler<IElement> EnqueueIdleElement;

        private event EventHandler StopProcessing;

        public RobotManager(int redRobots, int greenRobots, int blueRobots, int numberOfElements)
        {
            this.Logger = new /*ConsoleLogger*/NullLogger();

            this.NumberOfElements = numberOfElements;
            this.NumberOfRedRobots = redRobots;
            this.NumberOfGreenRobots = greenRobots;
            this.NumberOfBlueRobots = blueRobots;
            this.coreNumber = redRobots + greenRobots + blueRobots;

            this.EnqueueIdleElement += this.RobotManager_EnqueueIdleElement;
            this.StopProcessing += this.RobotManager_StopProcessing;
            // Distribute robots equaly
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

        public int ElapsedMilliseconds => (int) (stopWatch?.ElapsedMilliseconds ?? 0);

        private int WarehouseCount => warehouse.Count;

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

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        public void AddElementToWarehouse(IElement element)
        {
            this.warehouse.Enqueue(element);
            if (this.warehouse.Count == this.NumberOfElements)
            {
                var handler = this.StopProcessing;
                handler?.Invoke(this, EventArgs.Empty);
            }
        }

        private void RobotManager_StopProcessing(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void ClearBlockingCollection()
        {
            while (elements.TryTake(out _));
        }

        public void Start()
        {
            this.stopWatch = Stopwatch.StartNew();

            List<Task> tasks = new List<Task>();

            //Task.Run(() => this.CreateElements(this.numberOfElements));

            for (int i = 0; i < this.coreNumber; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => RunRobotSheduler(), TaskCreationOptions.LongRunning).ContinueWith(t => ReportStatus()));
            }

            //Task.WaitAll(tasks.ToArray());
        }

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
        }

        private void ProcessElement(IElement element)
        {           
            foreach (var robot in robots)
            {
                if (!robot.Busy)
                {
                    var stopWatch = Stopwatch.StartNew();
                    robot.Paint(element);
                    robot.AddExecutionTime((int)stopWatch.ElapsedMilliseconds);
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

        private void ElementCompleted(IElement element)
        {
            this.AddElementToWarehouse(element);
            Logger.TextColor = ConsoleColor.Cyan;
            Logger.Info($"Completed, transfering Element({(element as Element)?.Id}) to the warehouse.");
        }

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

        public void Stop()
        {
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
                    this.warehouse.Clear<IElement>();
                    this.robots.Clear<IRobot>();
                    ClearBlockingCollection();

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
