using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WpfApp1.MVVM;

namespace WpfApp1.Core.Converters
{
    public class MediaComboboxToVisibilityConverter : IValueConverter
    {
        public static MediaComboboxToVisibilityConverter Instance = new MediaComboboxToVisibilityConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string mediaTypeName = (string)value;
            Visibility visibility;
            if (mediaTypeName == "Game")
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
