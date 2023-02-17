using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WpfApp1.MVVM;

namespace WpfApp1.Core.Converters
{
    public class MediaListTypeToVisibilityConverter : IValueConverter
    {
        public static MediaListTypeToVisibilityConverter Instance = new MediaListTypeToVisibilityConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility;
            if (value is Game)
            {
                visibility = Visibility.Visible;
            }
            else visibility = Visibility.Hidden;

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
