using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Watchlist.Commands;
using Watchlist.Extensions;
using Watchlist.Models;

namespace Watchlist.ViewModels
{
    public class EntryListViewModel : BaseViewModel
    {
        public ObservableCollection<Series> SeriesCollection { get; }
        public int SelectedIndex { get; set; }

        public EntryListViewModel(IEnumerable<Series> seriesCollection)
        {
            SeriesCollection = seriesCollection.ToOvservableCollection();
        }
    }
}
