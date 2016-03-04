namespace Charts.Collection
{
    public class SimpleCategoryGraph
    {
        private string category;
        private double value;

        public SimpleCategoryGraph(string category, double value)
        {
            this.category = category;
            this.value = value;
        }
        public string Category
        {
            get
            {
                return this.category;
            }
        }
        public double Value
        {
            get
            {
                return this.value;
            }
        }
    }
}
