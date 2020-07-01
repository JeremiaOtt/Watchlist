using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Watchlist.Models;
using Watchlist.ViewModels;

namespace Watchlist.Commands
{
    public class AddNewEntryCommand : ICommand
    {
        private readonly MainViewModel _viewModel;
        private readonly Counter _counter;

        public event EventHandler CanExecuteChanged;

        public AddNewEntryCommand(MainViewModel viewModel, Counter counter)
        {
            _viewModel = viewModel;
            _counter = counter;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)   // ToDo: Prameter as enum
        {
            _viewModel.CurrentViewModel = new EntryViewModel(new Series(_counter, "Enter new name"));
        }
    }
}
