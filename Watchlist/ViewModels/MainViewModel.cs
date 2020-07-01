using System;
using System.Collections.Generic;
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

        public MainViewModel(SeriesSerializer seriesSerializer, Counter counter)
        {
            CurrentViewModel = new EntryListViewModel(seriesSerializer, this, counter);
        }
    }
}
