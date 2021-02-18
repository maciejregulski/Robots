using System;

namespace Robots.Model
{
    /// <summary>
    /// Paiting robot.
    /// </summary>
    public class Robot : IRobot
    {
        private int id;

        public IElementState State { get; set; }

        public int Interval { get; set; }

        public bool IsFinished
        {
            get => (this.State is ElementCompleted);
        }

        public Robot(int id, int interval)
        {
            this.id = id;
            this.Interval = interval;
        }

        public void ChangeState()
        {
            Console.WriteLine($"Robot # {id}");
            this.State.ChangeState(this);
        }
    }
}
