namespace Robots.Model
{
    public interface IRobot
    {
        IElementState State { get; set; }

        int Interval { get; set; }

        bool IsFinished { get; }

        void ChangeState();
    }
}
