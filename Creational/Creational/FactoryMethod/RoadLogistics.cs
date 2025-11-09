namespace Creational.FactoryMethod
{
    public class RoadLogistics: Logistics
    {
        public override ITransport createTransport()
        {
            return new Truck();
        }
    }
}
