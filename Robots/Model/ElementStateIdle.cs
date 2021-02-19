using System;

namespace Robots.Model
{
    public class ElementStateIdle : ElementStateBase, IElementState
    {
        public ElementStateIdle(IElement element) : base(element)
        {
        }

        public void ReturnToPool()
        {
        }

        public void PaintRed()
        {
            this.element.ChangeState(new ElementStateRed(this.element));
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
        }

        public void ReportState()
        {
            Console.WriteLine("Idle.");
        }
    }
}
