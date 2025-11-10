namespace Creational.Builder
{
    public class ConcreteBuilder1 : IBuilder
    {
        private Product1 result;

        public void Reset()
        {
            result = new Product1();
        }

        public void BuildStepA()
        {
            result.SetFeatureA("Step A done for Product1");
        }

        public void BuildStepB()
        {
            result.SetFeatureB("Step B done for Product1");
        }

        public void BuildStepZ()
        {
            result.SetFeatureZ("Step Z done for Product1");
        }

        public Product1 GetResult()
        {
            return result;
        }
    }
}
