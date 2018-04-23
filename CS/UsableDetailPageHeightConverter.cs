using System;
using System.Windows.Data;
using System.Windows.Markup;
using System.Globalization;

namespace PageHeightDemo {
    public class UsableDetailPageHeightConverter : MarkupExtension, IMultiValueConverter {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            double height = (double)values[0];

            for (int i = 1; i < values.Length; i++) {
                height -= (double)values[i];
            }

            return height;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter,
        CultureInfo culture) {
            throw new NotSupportedException();
        }


        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
