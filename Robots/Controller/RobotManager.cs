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
    public class RobotManager
    {
        private const int CoreNumber = 4;
        
        private readonly int numberOfElements;

        private readonly BlockingCollection<IElement> elements = new BlockingCollection<IElement>(new ConcurrentQueue<IElement>());

        private readonly ConcurrentQueue<IRobot> robots = new ConcurrentQueue<IRobot>();

        private readonly ConcurrentQueue<IElement> warehouse = new ConcurrentQueue<IElement>();

        private Stopwatch stopWatch = new Stopwatch();

        public RobotManager(int redRobots, int greenRobots, int blueRobots, int numberOfElements)
        {
            this.Logger = new ConsoleLogger();

            for (int i = 1; i <= redRobots; i++)
            {
                this.robots.Enqueue(new RobotRed(i, 1) { Logger = this.Logger });
            }
            for (int i = 1; i <= greenRobots; i++)
            {
                this.robots.Enqueue(new RobotGreen(i, 1) { Logger = this.Logger });
            }
            for (int i = 1; i <= blueRobots; i++)
            {
                this.robots.Enqueue(new RobotBlue(i, 1) { Logger = this.Logger });
            }

            this.numberOfElements = numberOfElements;
        }

        public ILogger Logger { get; set; }

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

        public int NumberOfElements => this.numberOfElements;

        private void CreateElements(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                this.AddElement(new Element(i));
            }
        }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        public void AddElements(IEnumerable<IElement> items)
        {
            foreach (var item in items)
            {
                AddElement(item);
            }
        }

        public void ClearQueue()
        {
            while (elements.TryTake(out _));
        }

        public void Start()
        {
            this.stopWatch = Stopwatch.StartNew();

            List<Task> tasks = new List<Task>();

            Task.Run(() => this.CreateElements(this.numberOfElements));

            for (int i = 0; i < CoreNumber; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => RunRobotSheduler()).ContinueWith(t => ReportStatus()));
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
                    robot.Paint(element);
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
            this.warehouse.Enqueue(element);
            Logger.TextColor = ConsoleColor.Cyan;
            Logger.Info($"Completed, transfering Element({(element as Element)?.Id}) to the warehouse.");
        }

        private void ElementIdle(IElement element)
        {
            this.AddElement(element);
            Logger.TextColor = ConsoleColor.DarkMagenta;
            Logger.Info($"Idle, returning Element({(element as Element)?.Id}) to the pool.");
        }

        public void Stop()
        {
            this.stopWatch.Stop();

            this.elements.CompleteAdding();
            
            foreach(var robot in robots)
            {
                robot.Abort = true;
            }

            ClearQueue();
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

            var elementStatistics = new ElementStatistics(this.numberOfElements, this.WarehouseCount, processed[0], processed[1], processed[2]);
            var robotStatistics = new RobotStatistics(busy[0], busy[1], busy[2], totalTime[0], totalTime[1], totalTime[2]);
            return new Statistics(elementStatistics, robotStatistics);
        }
    }
}
