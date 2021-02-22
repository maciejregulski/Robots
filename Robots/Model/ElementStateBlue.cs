﻿using System;

namespace Robots.Model
{
    public class ElementStateBlue: ElementStateBase, IElementState
    {
        public ElementStateBlue(IElement element) : base(element)
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
            this.element.ChangeState(new ElementStateGreen(this.element));
        }

        public void PaintBlue()
        {
            this.element.ChangeState(new ElementStateIdle(this.element));
        }

        public void FinishUp()
        {
            if (this.element.IsPainted)
            {
                this.element.ChangeState(new ElementStateCompleted(this.element));
            }
            else
            {
                this.element.ChangeState(new ElementStateIdle(this.element));
            }
        }
    }
}
