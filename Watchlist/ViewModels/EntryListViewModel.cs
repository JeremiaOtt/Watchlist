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
        public ObservableCollection<Series> Series { get; }

        public ICommand AddNewEntryCommand { get; set; }

        public EntryListViewModel(SeriesSerializer seriesSerializer,
                                  MainViewModel mainViewModel, Counter counter)
        {
            Series = seriesSerializer.Load().ToOvservableCollection();
            AddNewEntryCommand = new AddNewEntryCommand(mainViewModel, counter);
        }        

        // Not needed any more
        //public void AddEntry()
        //{
        //    _viewNewEntry(Series);

        //    //Testing
        //    //var name = "Naruto";
        //    //var watched = true;
        //    //Series.Add(new Series(new Counter(), name, watched));
        //    //Save();
        //}
    }
}
