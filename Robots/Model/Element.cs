using System;

namespace Robots.Model
{
    [Flags]
    public enum ElementColor
    {
        Raw = 0,
        Red = 1 << 0,
        Green = 1 << 1,
        Blue = 1 << 2,
        All = Red | Green | Blue
    }

    /// <summary>
    /// Element to be painted in three colors.
    /// </summary>
    public class Element : IElement
    {
        public int Id { get; private set; }

        protected IElementState State { get; set; }

        protected ElementColor Color = ElementColor.Raw;

        public Element(int id)
        {
            this.Id = id;
            this.State = new ElementStateIdle(this);
        }

        public bool IsRed => (this.Color & ElementColor.Red) == ElementColor.Red;

        public bool IsGreen => (this.Color & ElementColor.Green) == ElementColor.Green;

        public bool IsBlue => (this.Color & ElementColor.Blue) == ElementColor.Blue;

        public bool IsDone => (this.Color & ElementColor.All) == ElementColor.All;

        public void ReturnToPool()
        {
            this.State.ReturnToPool();
        }

        public void PaintRed()
        {
            if ((this.Color & ElementColor.Red) != ElementColor.Red)
            {
                this.State.PaintRed();
            }
        }

        public void PaintGreen()
        {
            if ((this.Color & ElementColor.Green) != ElementColor.Red)
            {
                this.State.PaintGreen();
            }
        }

        public void PaintBlue()
        {
            if ((this.Color & ElementColor.Blue) != ElementColor.Red)
            {
                this.State.PaintBlue();
            }
        }

        public void FinishUp()
        {
            if ((this.Color & ElementColor.All) == ElementColor.All)
            {
                this.State.FinishUp();
            }
            else
            {
                this.State.ReturnToPool();
            }
        }

        public void ChangeState(IElementState state)
        {
            this.State = state;

            if (state is ElementStateIdle)
            {
                // Fire event
            }
            else if (state is ElementStateRed)
            {
                this.Color |= ElementColor.Red;
            }
            else if (state is ElementStateGreen)
            {
                this.Color |= ElementColor.Green;
            }
            else if (state is ElementStateBlue)
            {
                this.Color |= ElementColor.Blue;
            }
            else if (state is ElementStateCompleted)
            {
                // Fire event
            }

            ReportState();
        }

        public void ReportState()
        {
            this.State.ReportState();
        }
    }
}
