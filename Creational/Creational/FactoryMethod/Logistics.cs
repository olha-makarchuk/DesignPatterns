namespace Creational.FactoryMethod
{
    public abstract class Logistics
    {
        public void planDelivery()
        {
            ITransport transport = createTransport();
            transport.deliver();
        }

        public abstract ITransport createTransport();
    }
}
