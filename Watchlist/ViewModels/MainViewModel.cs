using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
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
            var updateViewCommand = new UpdateViewCommand(this, storageSerializer, counter, seriesCollection);
            var content = new EntryListViewModel(seriesCollection);

            CurrentViewModel = new ShowEntryListViewModel(content, updateViewCommand);
        }
    }
}
