﻿using System;

namespace Robots.Model
{
    /// <summary>
    /// Paiting blue robot.
    /// </summary>
    public class RobotBlue: RobotBase, IRobot
    {
        public RobotBlue(int id, int interval) : base(id, interval)
        {
        }

        /// <inheritdoc />
        public void Paint(IElement element)
        {
            if (element.IsBlue)
            {
                return;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Robot({this.Id}) painting Element({element.Id}) Blue ({this.Interval}ms)");
            element.PaintBlue();
            this.SimulateJob();
            element.FinishUp();
        }
    }
}
