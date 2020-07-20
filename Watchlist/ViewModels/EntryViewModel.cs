using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Watchlist.Commands;
using Watchlist.Extensions;
using Watchlist.Models;

namespace Watchlist.ViewModels
{
    public class EntryViewModel : BaseViewModel
    {
        public Series SelectedSeries { get; set; }

        public ICommand UpdateViewCommand { get; set; }

        public ButtonViewModel Button { get; set; }

        public EntryViewModel(Series newSeries, UpdateViewCommand updateViewCommand,
                              ButtonViewModel buttonViewModel)
        {
            SelectedSeries = newSeries;
            UpdateViewCommand = updateViewCommand;
            Button = buttonViewModel;
        }
    }
}
