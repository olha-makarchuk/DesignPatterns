namespace Creational.Builder
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(IBuilder newBuilder)
        {
            builder = newBuilder;
        }

        public void Make(string type)
        {
            builder.Reset();

            if (type == "simple")
            {
                builder.BuildStepA();
            }
            else
            {
                builder.BuildStepB();
                builder.BuildStepZ();
            }
        }
    }
}
