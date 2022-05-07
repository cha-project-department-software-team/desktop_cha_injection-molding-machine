using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace MayEpCHADesktopApp.Core.ValueConverter
{
    public class IntToColorConverter : MarkupExtension, IValueConverter
    {
        static IntToColorConverter converter;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush solidColorBrush;
            switch (value)
            {
                //power off
                case 1:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                //Disconnect
                case 2:
                    solidColorBrush = new SolidColorBrush(Colors.Red);
                    break;
                //On Production
                case 3:
                    solidColorBrush = new SolidColorBrush(Colors.Blue);
                    break;
                //Idle
                case 4:
                    solidColorBrush = new SolidColorBrush(Colors.Purple);
                    break;
                //Error
                case 5:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                default:
                    solidColorBrush = new SolidColorBrush(Colors.Yellow);
                    break ;
            }
            return solidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null) converter = new IntToColorConverter();
            return converter;
        }
    }
}
