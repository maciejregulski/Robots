using System;

namespace Robots.Model
{
    public class ElementStateRed : ElementStateBase, IElementState
    {
        public ElementStateRed(IElement element) : base(element)
        {
        }

        public void ReturnToPool()
        {
            this.element.ChangeState(new ElementStateIdle(this.element));
        }

        public void PaintRed()
        {
        }

        public void PaintGreen()
        {
            this.element.ChangeState(new ElementStateGreen(this.element));
        }

        public void PaintBlue()
        {
            this.element.ChangeState(new ElementStateBlue(this.element));
        }

        public void FinishUp()
        {
            this.element.ChangeState(new ElementStateCompleted(this.element));
        }

        public void ReportState()
        {
            Console.WriteLine("Painting Red.");
        }
    }
}
