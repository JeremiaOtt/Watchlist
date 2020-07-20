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

        public ICommand UpdateViewCommand { get; set; }

        public EntryListViewModel(IEnumerable<Series> seriesCollection, UpdateViewCommand updateViewCommand)
        {
            SeriesCollection = seriesCollection.ToOvservableCollection();
            UpdateViewCommand = updateViewCommand;
        }
    }
}
