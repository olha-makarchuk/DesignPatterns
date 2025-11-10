using Creational.AbstractFactory.AbstractProducts;
using Creational.AbstractFactory.Interface;
using Creational.AbstractFactory.Victorian;

namespace Creational.AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new VictorianChair();
        public Sofa CreateSofa() => new VictorianSofa();
        public CoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
    }
}
