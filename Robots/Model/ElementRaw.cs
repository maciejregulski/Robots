using System;
using System.Threading;

namespace Robots.Model
{
    public class ElementRaw : IElementState
    {
        public void ChangeState(IRobot robot)
        {
            Console.WriteLine("Entered Raw.");
            // To be implemented as non-blocking
            Thread.Sleep(robot.Interval);
            robot.State = new ElementInProgress();
            robot.ChangeState();
        }

        public void ReportState()
        {
        }
    }
}
