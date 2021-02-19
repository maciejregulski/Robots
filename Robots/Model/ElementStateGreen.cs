using System;

namespace Robots.Model
{
    public class ElementStateGreen : ElementStateBase, IElementState
    {
        public ElementStateGreen(IElement element) : base(element)
        {
        }

        public void ReturnToPool()
        {
            this.element.ChangeState(new ElementStateIdle(this.element));
        }

        public void PaintRed()
        {
            this.element.ChangeState(new ElementStateRed(this.element));
        }

        public void PaintGreen()
        {
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
            Console.WriteLine("Painting Green.");
        }
    }
}
