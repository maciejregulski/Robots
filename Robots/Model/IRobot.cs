namespace Robots.Model
{
    public interface IRobot
    {
        int Id { get; }

        bool Busy { get; }

        bool Abort { get; set; }

        int Interval { get; set; }

        int Completed { get; }

        void Paint(IElement element);
    }
}
