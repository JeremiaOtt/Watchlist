using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Watchlist.Commands;
using Watchlist.Models;

namespace Watchlist.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainViewModel(StorageSerializer storageSerializer)
        {
            var storage = storageSerializer.Load();
            var seriesCollection = storage.SeriesCollection ?? new ObservableCollection<Series>();
            var counter = new Counter(storage.Id ?? 0);

            CurrentViewModel = new EntryListViewModel(seriesCollection,
                new UpdateViewCommand(this, storageSerializer, counter, seriesCollection));
        }
    }
}
