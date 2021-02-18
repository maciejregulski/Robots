namespace Robots.Model
{
    /// <summary>
    /// Element to be painted.
    /// </summary>
    public class Element
    {
        public int Id { get; set; }

        public IElementState Red { get; set; }

        public IElementState Green { get; set; }

        public IElementState Blue { get; set; }

        public Element()
        {
            this.Red = new ElementRaw();
            this.Green = new ElementRaw();
            this.Blue = new ElementRaw();
        }
    }
}
