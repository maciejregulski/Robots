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
            if (!element.IsRed)
            {
                Console.WriteLine($"#{this.Id} Robot Red");
                element.PaintRed();
                this.SimulateJob();
            }
            element.FinishUp();
        }
    }
}
