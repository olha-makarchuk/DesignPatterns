namespace Creational.Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        protected Shape() { }

        protected Shape(Shape source)
        {
            if (source != null)
            {
                X = source.X;
                Y = source.Y;
                Color = source.Color;
            }
        }

        public abstract Shape Clone();
    }
}
