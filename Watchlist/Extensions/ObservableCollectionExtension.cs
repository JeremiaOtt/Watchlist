using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Watchlist.Models;

namespace Watchlist.Extensions
{
    public static class ObservableCollectionExtension
    {
        public static ObservableCollection<Series> ToOvservableCollection(this IEnumerable<Series> series)
        {
            if(!(series is ObservableCollection<Series> observableSeries))
            {
                observableSeries = new ObservableCollection<Series>();

                foreach (var entry in series)
                    observableSeries.Add(entry);
            }

            return observableSeries;
        }
    }
}
