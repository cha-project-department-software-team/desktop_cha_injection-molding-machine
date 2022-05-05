using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MayEpCHADesktopApp.Core.ValueConverter
{
    public class IntToColorConverter : IValueConverter
    {
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
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                //On Production
                case 3:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                //Idle
                case 4:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                //Error
                case 5:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break;
                default:
                    solidColorBrush = new SolidColorBrush(Colors.White);
                    break ;
            }
            return solidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
