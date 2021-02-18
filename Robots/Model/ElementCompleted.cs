using System;

namespace Robots.Model
{
    public class ElementCompleted : IElementState
    {
        public void ChangeState(IRobot robot)
        {
            Console.WriteLine("Entered Completed.");
        }

        public void ReportState()
        {
        }
    }
}
