namespace Robots.Model
{
    public interface IRobot
    {
        bool Busy { get; }

        void Paint(IElement element);
    }
}
