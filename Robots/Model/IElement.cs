using System;

namespace Robots.Model
{
    public interface IElement
    {
        event EventHandler<EventArgs> Idle;

        event EventHandler<EventArgs> Completed;

        bool IsRed { get; }

        bool IsGreen { get; }

        bool IsBlue { get; }

        bool IsComplete { get; }

        void ReturnToPool();

        void PaintRed();

        void PaintGreen();

        void PaintBlue();

        void FinishUp();

        void ChangeState(IElementState state);

        void ReportState();
    }
}
