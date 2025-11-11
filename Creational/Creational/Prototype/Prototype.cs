namespace Creational.Prototype
{
    public class Prototype
    {
        Shape circle = new Circle { X = 10, Y = 20, Color = "Red", Radius = 15 };

        Shape rectangle = new Rectangle { X = 30, Y = 40, Color = "Blue", Width = 10, Height = 20 };

        public void Start()
        {
            Shape clonedCircle = circle.Clone();
            Shape clonedRectangle = rectangle.Clone();

            Console.WriteLine("Original Circle: X={0}, Y={1}, Color={2}", circle.X, circle.Y, circle.Color);
            Console.WriteLine("Cloned Circle:   X={0}, Y={1}, Color={2}", clonedCircle.X, clonedCircle.Y, clonedCircle.Color);

            Console.WriteLine(circle == clonedCircle
                ? "❌ Circle cloning failed (same reference)."
                : "✅ Circle cloned successfully (different object).");

            Console.WriteLine(rectangle == clonedRectangle
                ? "❌ Rectangle cloning failed (same reference)."
                : "✅ Rectangle cloned successfully (different object).");
        }
    }
}
