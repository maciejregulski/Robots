using System;

namespace Robots.Model
{
    public interface IElement
    {
        int Id { get; }

        bool IsRed { get; }

        bool IsGreen { get; }

        bool IsBlue { get; }

        bool IsPainted { get; }

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
