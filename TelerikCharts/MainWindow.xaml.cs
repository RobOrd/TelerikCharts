using System.Collections.Generic;
using System.Windows;

namespace TelerikCharts
{
    public class PerformanceData
    {
        private string quarter;
        private string name;
        private double performance;

        public PerformanceData(string name, string quarter, double performance)
        {
            this.name = name;
            this.quarter = quarter;
            this.performance = performance;
        }

        public string QuarterName
        {
            get
            {
                return this.quarter;
            }
        }
        public string RepresentativeName
        {
            get
            {
                return this.name;
            }
        }
        public double Performance
        {
            get
            {
                return this.performance;
            }
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private IEnumerable<PerformanceData> q1;
        public IEnumerable<PerformanceData> Q1
        {
            get
            {
                if (this.q1 == null)
                {
                    this.q1 = new List<PerformanceData>() {
                        new PerformanceData("Jason Harley", "Q1, 2010", 17790),
                        new PerformanceData("Adam White", "Q1, 2010", 12820),
                        new PerformanceData("Barbara Smith", "Q1, 2010", 14350),
                        new PerformanceData("Susan Jones", "Q1, 2010", 11150),
                        new PerformanceData("Tom Marshall", "Q1, 2010", 11800)
                    };
                }

                return this.q1;
            }
        }

        private void LoadData()
        {
            this.DataContext = this;
        }
    }
}
