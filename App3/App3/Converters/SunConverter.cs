using System;
using System.Collections.Generic;
using System.Globalization;
using App3.Models;
using System.Text;
using Xamarin.Forms;

namespace App3.Converters
{
    class SunConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var sun = value as Sun;
            if(! string.IsNullOrWhiteSpace(sun?.Sunrise))
                return $"Levé: {sun.Sunrise}, couché: {sun.Sunset}";
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
