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

        private readonly object syncRoot = new object();

        public IElementState State { get; private set; }

        private ElementColor Color = ElementColor.Raw;

        public Element(int id)
        {
            this.Id = id;
            this.State = new ElementStateIdle(this);
        }

        public bool IsRed => (this.Color & ElementColor.Red) == ElementColor.Red;

        public bool IsGreen => (this.Color & ElementColor.Green) == ElementColor.Green;

        public bool IsBlue => (this.Color & ElementColor.Blue) == ElementColor.Blue;

        public bool IsPainted => (this.Color & ElementColor.All) == ElementColor.All;

        public bool IsComplete => this.State is ElementStateCompleted;

        public void ReturnToPool()
        {
            this.State.ReturnToPool();
        }

        public void PaintRed()
        {
            if (this.IsRed)
            {
                throw new PaintException("Element was already painted Red.");
            }
            this.State.PaintRed();

        }

        public void PaintGreen()
        {
            if (this.IsGreen)
            {
                throw new PaintException("Element was already painted Green.");
            }
            this.State.PaintGreen();
        }

        public void PaintBlue()
        {
            if (this.IsBlue)
            {
                throw new PaintException("Element was already painted Blue.");
            }
            this.State.PaintBlue();
        }

        public void FinishUp()
        {
            this.State.FinishUp();
        }

        public void ChangeState(IElementState state)
        {
            lock (this.syncRoot)
            {
                this.State = state;

                if (state is ElementStateRed)
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
            }
        }
    }
}
