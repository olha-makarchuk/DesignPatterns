using Creational.AbstractFactory.AbstractProducts;
using Creational.AbstractFactory.Interface;
using Creational.AbstractFactory.Modern;

namespace Creational.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ModernChair();
        public Sofa CreateSofa() => new ModernSofa();
        public CoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
    }
}
