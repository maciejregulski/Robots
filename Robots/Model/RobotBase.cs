using System;
using System.Threading;

namespace Robots.Model
{
    /// <summary>
    /// Paiting robot.
    /// </summary>
    public abstract class RobotBase
    {
        public int Id { get; private set; }

        public int Interval { get; set; }

        protected RobotBase(int id, int interval)
        {
            this.Id = id;
            this.Interval = interval;
        }

        protected void SimulateJob()
        {
            // To be implemented as non-blocking; ToDo: different intervals for each color
            Thread.Sleep(this.Interval);
        }
    }
}
