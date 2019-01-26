using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace YalantisMarketing.Classes.Converters
{
    public class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return   System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                 Properties.Resources.found.GetHbitmap(),
                 IntPtr.Zero,
                 Int32Rect.Empty,
                 BitmapSizeOptions.FromEmptyOptions());
            else
                return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                 Properties.Resources.not_found.GetHbitmap(),
                 IntPtr.Zero,
                 Int32Rect.Empty,
                 BitmapSizeOptions.FromEmptyOptions());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
