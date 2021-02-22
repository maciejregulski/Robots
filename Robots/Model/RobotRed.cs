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

            Logger.TextColor = ConsoleColor.Red;
            Logger.Info($"Robot({this.Id}) painting Element({element.Id}) Red ({this.Interval}ms)");
            if (this.SimulateJob())
            {
                element.PaintRed();
            }
        }
    }
}
