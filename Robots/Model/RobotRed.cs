using System;

namespace Robots.Model
{
    /// <summary>
    /// Paiting red robot.
    /// </summary>
    public class RobotRed : RobotBase, IRobot
    {
        public RobotRed(int id, int interval) : base(id, interval)
        {
        }

        /// <inheritdoc />
        public void Paint(IElement element)
        {
            if (element.IsRed)
            {
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Robot({this.Id}) painting Element({element.Id}) Red ({this.Interval}ms)");
            element.PaintRed();
            this.SimulateJob();
        }
    }
}
