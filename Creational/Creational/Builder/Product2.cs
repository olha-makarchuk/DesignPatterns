namespace Creational.Builder
{
    public class Product2
    {
        private string featureA;
        private string featureB;
        private string featureZ;

        public void SetFeatureA(string value) => featureA = value;
        public void SetFeatureB(string value) => featureB = value;
        public void SetFeatureZ(string value) => featureZ = value;

        public override string ToString()
        {
            return $"{featureA}, {featureB}, {featureZ}";
        }
    }
}
