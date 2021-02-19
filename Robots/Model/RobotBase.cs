using System;
using System.Threading;
using Robots.Extensions;

namespace Robots.Model
{
    /// <summary>
    /// Paiting robot.
    /// </summary>
    public abstract class RobotBase
    {
        private readonly AtomicBoolean busy = new AtomicBoolean();

        public int Id { get; private set; }

        /// <summary>
        /// Different interval for each color.
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// ToDo: should be atomic boolean.
        /// </summary>
        public bool Abort { get; set; }

        /// <summary>
        /// This tells if the robot has the capacity to process the job. Thread safe boolean.
        /// </summary>
        public bool Busy
        {
            get => this.busy.Value;
            private set => this.busy.Value = value;
        }

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
            this.Busy = true;
            //Thread.Sleep(this.Interval);
            SpinWait.SpinUntil(() => this.Abort, this.Interval);
            this.Busy = false;
        }
    }
}
