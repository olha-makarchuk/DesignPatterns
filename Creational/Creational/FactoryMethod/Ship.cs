namespace Creational.FactoryMethod
{
    public class Ship : ITransport
    {
        public void deliver() => Console.WriteLine("Доставка морем");
    }
}
