using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using Watchlist.Emum;
using Watchlist.Pages;

namespace Watchlist.Converter
{
    public class PageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Page)value) switch
            {
                Page.EntryList => new EntryList(),
                Page.EntryView => new EntryView(),
                _ => throw new Exception($"{nameof(PageValueConverter)}: value({value}) is invalid"),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
