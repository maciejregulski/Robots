using System;

namespace Robots.Model
{
    public class ElementStateCompleted : ElementStateBase, IElementState
    {
        public ElementStateCompleted(IElement element) : base(element)
        {
        }

        public void ReturnToPool()
        {
        }

        public void PaintRed()
        {
        }

        public void PaintGreen()
        {
        }

        public void PaintBlue()
        {
        }

        public void FinishUp()
        {
        }
    }
}
