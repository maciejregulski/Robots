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
            for (int i = 0; i < reds; i++)
            {
                this.redRobots.Add(new Robot(i + 1, 550));
            }
            for (int i = 0; i < greens; i++)
            {
                this.greenRobots.Add(new Robot(i + 1, 900));
            }
            for (int i = 0; i < blues; i++)
            {
                this.blueRobots.Add(new Robot(i + 1, 800));
            }
        }

        public void Start()
        {
            var element = new Element();

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var robot in redRobots)
            {
                robot.State = element.Red;
                robot.ChangeState();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var robot in greenRobots)
            {
                robot.State = element.Green;
                robot.ChangeState();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var robot in blueRobots)
            {
                robot.State = element.Blue;
                robot.ChangeState();
            }

        }
    }
}
