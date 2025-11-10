using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Victorian
{
    public class VictorianChair : Chair
    {
        public override void HasLegs() => Console.WriteLine("Victorian chair has carved wooden legs.");
        public override void SitOn() => Console.WriteLine("You sit on a plush Victorian chair.");
    }
}
