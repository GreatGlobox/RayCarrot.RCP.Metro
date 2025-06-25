using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace RayCarrot.RCP.Metro
{
    public class GenericIconToBrushConverter : IValueConverter
    {
        public static readonly GenericIconToBrushConverter Instance = new GenericIconToBrushConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string iconKey && Avalonia.Application.Current?.Resources.TryGetResource(iconKey, null, out var resource) == true)
            {
                if (resource is GenericIcon icon)
                    return icon.IconColor;
            }

            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
