using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Robots.Model;

namespace Robots.Controller
{
    /// <summary>
    /// Robot manager.
    /// </summary>
    public class RobotManager
    {
        private readonly BlockingCollection<IElement> elementQueue = new BlockingCollection<IElement>(new ConcurrentQueue<IElement>());

        List<IRobot> redRobots = new List<IRobot>();
        List<IRobot> greenRobots = new List<IRobot>();
        List<IRobot> blueRobots = new List<IRobot>();

        public RobotManager(int reds, int greens, int blues, int elements)
        {
            for (int i = 1; i <= reds; i++)
            {
                this.redRobots.Add(new RobotRed(i, 650));
            }
            for (int i = 1; i <= greens; i++)
            {
                this.greenRobots.Add(new RobotGreen(i, 920));
            }
            for (int i = 1; i <= blues; i++)
            {
                this.blueRobots.Add(new RobotBlue(i, 1250));
            }

            Task.Run(() => this.FillElements(elements));
            //Task.Run(() => this.Start());
        }

        private void FillElements(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                var element = new Element(i);
                element.Idle += Element_Idle;
                element.Completed += Element_Completed;
                this.AddElement(element);
            }
        }

        private void Element_Completed(object sender, EventArgs e)
        {
            Console.WriteLine($"Completed, transfering Element(#{(sender as Element)?.Id}) to the warehouse.");
        }

        private void Element_Idle(object sender, EventArgs e)
        {
            this.AddElement(sender as IElement);
            Console.WriteLine($"Idle, returning Element(#{(sender as Element)?.Id}) to the pool.");
        }

        public void AddElement(IElement element)
        {
            elementQueue.Add(element);
        }

        public void AddElements(IEnumerable<IElement> items)
        {
            foreach (var item in items)
            {
                elementQueue.Add(item);
            }
        }

        public void ClearQueue()
        {
            while (elementQueue.TryTake(out _))
            {
            }
        }

        public void Start()
        {
            foreach (var item in elementQueue.GetConsumingEnumerable())
            {
                ProcessElement(item);
            }
        }

        public void ProcessElement(IElement element)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var robot in redRobots)
            {
                robot.Paint(element);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var robot in greenRobots)
            {
                robot.Paint(element);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var robot in blueRobots)
            {
                robot.Paint(element);
            }

        }
    }
}
