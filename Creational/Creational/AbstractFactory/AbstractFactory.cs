using Creational.AbstractFactory.Interface;

namespace Creational.AbstractFactory
{
    public class AbstractFactory
    {
        public void Start()
        {
            IFurnitureFactory factory;

            factory = new ModernFurnitureFactory();
            Console.WriteLine("Modern style:");
            factory.CreateChair().SitOn();
            factory.CreateSofa().LieOn();
            factory.CreateCoffeeTable().PutCoffeeOn();

            Console.WriteLine();

            factory = new VictorianFurnitureFactory();
            Console.WriteLine("Victorian style:");
            factory.CreateChair().SitOn();
            factory.CreateSofa().LieOn();
            factory.CreateCoffeeTable().PutCoffeeOn();
        }
    }
}
