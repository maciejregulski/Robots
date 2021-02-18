using System;
using System.Threading;

namespace Robots.Model
{
    public class ElementInProgress : IElementState
    {
        public void ChangeState(IRobot robot)
        {
            Console.WriteLine("Entered InProgress.");
            // To be implemented as non-blocking
            Thread.Sleep(robot.Interval);
            robot.State = new ElementCompleted();
            robot.ChangeState();
        }

        public void ReportState()
        {
        }
    }
}
