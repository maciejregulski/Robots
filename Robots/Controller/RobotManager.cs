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

        private List<IRobot> robots = new List<IRobot>();

        public RobotManager(int reds, int greens, int blues, int elements)
        {
            for (int i = 1; i <= reds; i++)
            {
                this.robots.Add(new RobotRed(i, 650));
            }
            for (int i = 1; i <= greens; i++)
            {
                this.robots.Add(new RobotGreen(i, 920));
            }
            for (int i = 1; i <= blues; i++)
            {
                this.robots.Add(new RobotBlue(i, 1250));
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Completed, transfering Element(#{(sender as Element)?.Id}) to the warehouse.");
        }

        private void Element_Idle(object sender, EventArgs e)
        {
            this.AddElement(sender as IElement);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
                Task.Run(() => ProcessElement(item));
            }
        }

        public void ProcessElement(IElement element)
        {           
            foreach (var robot in robots)
            {
                if (!robot.Busy)
                {
                    robot.Paint(element);
                }
            }
        }
    }
}
