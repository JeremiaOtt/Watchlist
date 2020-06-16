using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Watchlist.ViewModels.Interfaces;

namespace Watchlist.ViewModels
{
    public class EntryListViewModel : IViewModel
    {
        public ObservableCollection<Series> Series { get; }
        //public IViewModel CurrentView { get { return this; } }

        public EntryListViewModel(ObservableCollection<Series>  series)
        {
            Series = series;
        }

        public void AddEntry()
        {
            //Testing
            var name = "Naruto";
            var watched = true;
            Series.Add(new Series(new Counter(), name, watched));
            //Save();
        }
    }
}
