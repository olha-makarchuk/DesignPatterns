using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Interface
{
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        CoffeeTable CreateCoffeeTable();
    }
}
