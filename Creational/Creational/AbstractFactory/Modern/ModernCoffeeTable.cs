using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Modern
{
    public class ModernCoffeeTable : CoffeeTable
    {
        public override void PutCoffeeOn() => Console.WriteLine("Coffee on a glass modern table.");
    }
}
