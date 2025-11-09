namespace Creational.FactoryMethod
{
    public class Truck : ITransport
    {
        public void deliver() => Console.WriteLine("Доставка автотранспортом");
    }
}
