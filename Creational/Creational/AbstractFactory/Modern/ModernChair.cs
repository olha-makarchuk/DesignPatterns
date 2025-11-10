using Creational.AbstractFactory.AbstractProducts;

namespace Creational.AbstractFactory.Modern
{
    public class ModernChair : Chair
    {
        public override void HasLegs() => Console.WriteLine("Modern chair has steel legs.");
        public override void SitOn() => Console.WriteLine("You sit on a sleek modern chair.");
    }
}
