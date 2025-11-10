namespace Creational.Builder
{
    public interface IBuilder
    {
        void Reset();
        void BuildStepA();
        void BuildStepB();
        void BuildStepZ();
    }
}
