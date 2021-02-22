namespace Robots.Model
{
    public interface IElementState
    {
        void ReturnToPool();

        void PaintRed();

        void PaintGreen();

        void PaintBlue();

        void FinishUp();
    }
}
