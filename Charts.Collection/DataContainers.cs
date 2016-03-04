using System.Collections;
using System.Collections.Generic;

namespace Charts.Collection
{
    public class SimpleCategoryGraphCollection : IEnumerable<SimpleCategoryGraph>
    {
        public string HorizontalTitle { get; set; }
        public string VerticalTitle { get; set; }

        List<SimpleCategoryGraph> collection = new List<SimpleCategoryGraph>();

        public SimpleCategoryGraphCollection(string horizontalTitle, string verticalTitle)
        {
            this.HorizontalTitle = horizontalTitle;
            this.VerticalTitle = verticalTitle;
        }

        public void AddRange(List<SimpleCategoryGraph> data)
        {
            this.collection.AddRange(data);
        }
        public SimpleCategoryGraph this[int index]
        {
            get { return collection[index]; }
            set { collection.Insert(index, value); }
        }
        public IEnumerator<SimpleCategoryGraph> GetEnumerator()
        {
            return collection.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

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
