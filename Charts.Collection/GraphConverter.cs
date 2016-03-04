using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Telerik.Windows.Controls.ChartView;
using System.Windows.Media;
using Telerik.Windows.Controls.DataBars;
using Telerik.Charting;

namespace Charts.Collection
{
    public static class RandomGen
    {
        public static Random ran = new Random();
    }
    public class RandomBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            BrushCollection brushes = parameter as BrushCollection;
            var index = RandomGen.ran.Next(0, brushes.Count());

            return brushes[index];
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
