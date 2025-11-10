using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Victorian
{

    public class VictorianSofa : Sofa
    {
        public override void HasCushions() => Console.WriteLine("Victorian sofa has ornate cushions.");
        public override void LieOn() => Console.WriteLine("Lying on a Victorian sofa.");
    }
}
