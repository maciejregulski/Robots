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
        private int completed = 0;

        private int processingTime = 0;

        private readonly AtomicBoolean busy = new AtomicBoolean();

        private readonly AtomicBoolean abort = new AtomicBoolean();

        public int Id { get; private set; }

        public ILogger Logger { get; set; }

        public int Interval { get; set; }

        public int Completed => this.completed;

        public int ProcessingTime => this.processingTime;

        public bool Abort
        {
            get => this.abort.Value;
            set => this.abort.Value = value;
        }

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

        /// <summary>
        /// Manipulates private fields to gather process statistics.
        /// </summary>
        protected void IncrementCompleted()
        {
            Interlocked.Increment(ref this.completed);
            Interlocked.Add(ref this.processingTime, this.Interval);

        }
    }
}
