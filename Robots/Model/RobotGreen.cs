using System;

namespace Robots.Model
{
    /// <summary>
    /// Paiting green robot.
    /// </summary>
    public class RobotGreen : RobotBase, IRobot
    {
        public RobotGreen(int id, int interval) : base(id, interval)
        {
        }

        /// <inheritdoc />
        public void Paint(IElement element)
        {
            if (element.IsGreen)
            {
                return;
            }

            if (this.SimulateJob())
            {
                element.PaintGreen();
                this.IncrementCompleted();
            }

            Logger.TextColor = ConsoleColor.Green;
            Logger.Info($"Robot({this.Id}) painting Element({element.Id}) Green ({this.Interval}ms)");
        }
    }
}
