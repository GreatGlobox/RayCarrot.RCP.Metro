using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace RayCarrot.RCP.Metro
{
    public class GenericIconToIconKeyConverter : IValueConverter
    {
        public static readonly GenericIconToIconKeyConverter Instance = new GenericIconToIconKeyConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string iconResourceKey 
                && Avalonia.Application.Current?.Resources.TryGetResource(iconResourceKey, null, out var resource) == true)
            {
                if (resource is GenericIcon icon)
                    return icon.IconKey;  // Return the string icon key
            }

            return null;  // or return a default icon key string
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
