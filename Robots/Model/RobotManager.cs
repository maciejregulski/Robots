using System;
using System.Collections.Generic;

namespace Robots.Model
{
    /// <summary>
    /// Robot manager.
    /// </summary>
    public class RobotManager
    {
        List<IRobot> redRobots = new List<IRobot>();
        List<IRobot> greenRobots = new List<IRobot>();
        List<IRobot> blueRobots = new List<IRobot>();

        public RobotManager(int reds, int greens, int blues)
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
        }

        public void Start()
        {
            var element = new Element(1);
            element.Idle += (s, e) =>
            {
                Console.WriteLine($"Idle, returning #{(s as Element)?.Id} Element to the pool.");
            };
            element.Completed += (s, e) =>
            {
                Console.WriteLine($"Completed, transfering #{(s as Element)?.Id} Element to the warehouse.");
            };

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
