namespace Creational.FactoryMethod
{
    public class FactoryMethod
    {
        public void Start()
        {
            Logistics seaLogistics = new SeaLogistics();
            seaLogistics.planDelivery();

            Logistics roadLogistics = new RoadLogistics();
            roadLogistics.planDelivery();
        }
    }
}
