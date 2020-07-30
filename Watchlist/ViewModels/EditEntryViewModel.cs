using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Watchlist.Commands;

namespace Watchlist.ViewModels
{
    public class EditEntryViewModel : BaseViewModel
    {
        public EntryViewModel CurrentContent { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        public EditEntryViewModel(EntryViewModel currentContent, UpdateViewCommand updateViewCommand)
        {
            CurrentContent = currentContent;
            UpdateViewCommand = updateViewCommand;
        }
    }
}
