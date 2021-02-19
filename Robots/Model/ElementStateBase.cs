namespace Robots.Model
{
    public abstract class ElementStateBase
    {
        protected readonly IElement element;

        protected ElementStateBase(IElement element)
        {
            this.element = element;
        }
    }
}
