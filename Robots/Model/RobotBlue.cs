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
            if (!element.IsBlue)
            {
                Console.WriteLine($"#{this.Id} Robot Blue");
                element.PaintBlue();
                this.SimulateJob();
            }
            element.FinishUp();
        }
    }
}
