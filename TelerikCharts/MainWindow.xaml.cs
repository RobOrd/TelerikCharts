using Charts.Collection;
using System.Collections.Generic;
using System.Windows;
using System;

namespace TelerikCharts
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private IEnumerable<SimpleCategoryGraph> simpleCategory;
        public IEnumerable<SimpleCategoryGraph> SimpleCategory
        {
            get
            {
                return this.simpleCategory;
            }
        }

        private void LoadData()
        {
            LoadSimpleVariableData();

            this.DataContext = this;
        }

        private void LoadSimpleVariableData()
        {
            this.simpleCategory = new List<SimpleCategoryGraph>() {
                        new SimpleCategoryGraph("Jason Harley", 17790),
                        new SimpleCategoryGraph("Adam White", 12820),
                        new SimpleCategoryGraph("Barbara Smith", 14350),
                        new SimpleCategoryGraph("Susan Jones", 11150),
                        new SimpleCategoryGraph("Tom Marshall", 11800)
                    };
        }
    }
}
