using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Watchlist.Commands;

namespace Watchlist.ViewModels
{
    public class AddEntryViewModel : BaseViewModel
    {
        public EntryViewModel CurrentContent { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        public AddEntryViewModel(EntryViewModel currentContent, UpdateViewCommand updateViewCommand)
        {
            CurrentContent = currentContent;
            UpdateViewCommand = updateViewCommand;
        }
    }
}
