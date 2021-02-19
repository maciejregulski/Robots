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

        /// <summary>
        /// Different interval for each color.
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// ToDo: should be atomic boolean.
        /// </summary>
        public bool Abort { get; set; }

        protected RobotBase(int id, int interval)
        {
            this.Id = id;
            this.Interval = interval;
        }

        /// <summary>
        /// Implemented as non-blocking busy wait object (safe spin lock).
        /// </summary>
        protected void SimulateJob()
        {
            //Thread.Sleep(this.Interval);
            SpinWait.SpinUntil(() => this.Abort, this.Interval);
        }
    }
}
