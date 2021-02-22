using System;
using System.Threading;
using Robots.Extensions;
using Robots.Log;

namespace Robots.Model
{
    /// <summary>
    /// Paiting robot.
    /// </summary>
    public abstract class RobotBase
    {
        private readonly AtomicBoolean busy = new AtomicBoolean();

        public int Id { get; private set; }

        public ILogger Logger { get; set; }

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
            this.Logger = new NullLogger();
            this.Id = id;
            this.Interval = interval;
        }

        /// <summary>
        /// Implemented as non-blocking busy wait object (safe spin lock).
        /// </summary>
        /// <returns>True if job is executed; false if aborted.</returns>
        protected bool SimulateJob()
        {
            this.Busy = true;
            //Thread.Sleep(this.Interval);
            bool abort = SpinWait.SpinUntil(() => this.Abort, this.Interval);
            this.Busy = false;
            return !abort;
        }
    }
}
