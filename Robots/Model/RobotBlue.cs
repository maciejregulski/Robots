using System;

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

            Logger.TextColor = ConsoleColor.Blue;
            Logger.Info($"Robot({this.Id}) painting Element({element.Id}) Blue ({this.Interval}ms)");
            if (this.SimulateJob())
            {
                element.PaintBlue();
            }
        }
    }
}
