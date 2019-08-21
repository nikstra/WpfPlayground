using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProgressAndSlide
{
    public class ProgressPercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is double position && parameter is double completedValue && completedValue > 0)
            {
                // Hardcoded multiply by 100 as it is the default Maximum of ProgressBar.
                // A IMultiValueConverter could be used to pass the ProgressBar object as
                // an additional value to get the actual Maximum property's value.
                return position / completedValue * 100d;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
