using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Victorian
{
    public class VictorianCoffeeTable : CoffeeTable
    {
        public override void PutCoffeeOn() => Console.WriteLine("Coffee on a wooden Victorian table.");
    }
}
