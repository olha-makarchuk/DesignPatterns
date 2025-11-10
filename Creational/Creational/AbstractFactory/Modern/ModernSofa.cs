using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Modern
{
    public class ModernSofa : Sofa
    {
        public override void HasCushions() => Console.WriteLine("Modern sofa has minimal cushions.");
        public override void LieOn() => Console.WriteLine("Lying on a modern sofa.");
    }
}
