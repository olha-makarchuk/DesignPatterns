namespace Creational.Builder
{
    public class ConcreteBuilder2 : IBuilder
    {
        private Product2 result;

        public void Reset()
        {
            result = new Product2();
        }

        public void BuildStepA()
        {
            result.SetFeatureA("Step A done for Product2");
        }

        public void BuildStepB()
        {
            result.SetFeatureB("Step B done for Product2");
        }

        public void BuildStepZ()
        {
            result.SetFeatureZ("Step Z done for Product2");
        }

        public Product2 GetResult()
        {
            return result;
        }
    }
}
