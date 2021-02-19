namespace Robots.Model
{
    public interface IElement
    {
        bool IsRed { get; }

        bool IsGreen { get; }

        bool IsBlue { get; }

        bool IsDone { get; }

        void ReturnToPool();

        void PaintRed();

        void PaintGreen();

        void PaintBlue();

        void FinishUp();

        void ChangeState(IElementState state);

        void ReportState();
    }
}
