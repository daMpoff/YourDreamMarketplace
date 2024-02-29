using System.Globalization;
using System.Windows.Data;

namespace YourDreamMarketplace
{
    [ValueConversion(typeof(decimal), typeof(string))]
    public class PriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            decimal price = (decimal)value;
            culture = new System.Globalization.CultureInfo("ru-RU");
            return price.ToString("C", culture);
        }
        public object ConvertBack(object value, Type targetType, object parametr, CultureInfo culture)
        {
            string price = value.ToString();
            culture = new System.Globalization.CultureInfo("ru-RU");
            if (Decimal.TryParse(price, NumberStyles.AllowDecimalPoint, culture, out decimal result))
            {
                return result;
            }
            return value;
        }
    }
}
