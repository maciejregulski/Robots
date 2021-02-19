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
            if (!element.IsGreen)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Robot(#{this.Id}) Green");
                element.PaintGreen();
                this.SimulateJob();
            }
            element.FinishUp();
        }
    }
}
