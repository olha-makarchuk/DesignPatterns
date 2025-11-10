namespace Creational.Builder
{
    internal class Builder
    {
        public void Start()
        {
            var builder1 = new ConcreteBuilder1();
            var director = new Director(builder1);

            director.Make("simple");
            var product1 = builder1.GetResult();
            Console.WriteLine($"Product1: {product1}");

            var builder2 = new ConcreteBuilder2();
            director.ChangeBuilder(builder2);

            director.Make("complex");
            var product2 = builder2.GetResult();
            Console.WriteLine($"Product2: {product2}");
        }
    }
}
