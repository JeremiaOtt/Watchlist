using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Watchlist.Models;

namespace Watchlist.Extensions
{
    public static class ObservableCollectionExtension
    {
        public static ObservableCollection<Series> ToOvservableCollection(this IEnumerable<Series> series)
        {
            var seriesCollection = new ObservableCollection<Series>();

            if (series == null)
                return seriesCollection;

            if (series is ObservableCollection<Series> ocSeries)
                return ocSeries;

            foreach (var entry in series)
                seriesCollection.Add(entry);

            return seriesCollection;
        }
    }
}
