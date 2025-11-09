namespace Creational.FactoryMethod
{
    public class SeaLogistics: Logistics
    {
        public override ITransport createTransport()
        {
            return new Ship();
        }
    }
}
