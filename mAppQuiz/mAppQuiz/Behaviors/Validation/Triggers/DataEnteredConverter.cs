using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mAppQuiz.Behaviors.Validation.Triggers
{
    public class DataEnteredConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object param, CultureInfo culture)
        {
            Debug.WriteLine("check");
            if ((int)value > 0)
                return true;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType,
            object param, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
