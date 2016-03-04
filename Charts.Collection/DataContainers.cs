namespace Charts.Collection
{
    public class SimpleVariableGraph
    {
        private string category;
        private double value;

        public SimpleVariableGraph(string category, double value)
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
