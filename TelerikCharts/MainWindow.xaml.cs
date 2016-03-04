using Charts.Collection;
using System.Collections.Generic;
using System.Windows;

namespace TelerikCharts
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private IEnumerable<SimpleVariableGraph> q1;
        public IEnumerable<SimpleVariableGraph> Q1
        {
            get
            {
                if (this.q1 == null)
                {
                    this.q1 = new List<SimpleVariableGraph>() {
                        new SimpleVariableGraph("Jason Harley", 17790),
                        new SimpleVariableGraph("Adam White", 12820),
                        new SimpleVariableGraph("Barbara Smith", 14350),
                        new SimpleVariableGraph("Susan Jones", 11150),
                        new SimpleVariableGraph("Tom Marshall", 11800)
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
