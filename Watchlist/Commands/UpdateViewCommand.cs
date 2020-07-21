using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Watchlist.Enum;
using Watchlist.Extensions;
using Watchlist.Models;
using Watchlist.ViewModels;

namespace Watchlist.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;
        private readonly StorageSerializer _storageSerializer;
        private readonly Counter _counter;
        private IEnumerable<Series> _seriesCollection;

        public event EventHandler CanExecuteChanged;

        public UpdateViewCommand(MainViewModel mainViewModel, StorageSerializer storageSerializer,
                                 Counter counter, IEnumerable<Series> seriesCollection)
        {
            _mainViewModel = mainViewModel;
            _storageSerializer = storageSerializer;
            _counter = counter;
            _seriesCollection = seriesCollection;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!(parameter is UpdateView))
            {
                throw new ArgumentException($"UpdateViewCommand.Execute: Unknown parameter type({ parameter.GetType() })");
            }

            switch ((UpdateView)parameter)
            {
                case UpdateView.EntryList_NewEntry:
                    var series = new Series(_counter, "Enter new name");
                    _mainViewModel.CurrentViewModel = new AddFrameViewModel(new EntryViewModel(series), this);
                    break;
                case UpdateView.Add_Ok:
                    if (_mainViewModel.CurrentViewModel is AddFrameViewModel currentViewModel)
                    {
                        var newCollection = _seriesCollection.ToOvservableCollection();
                        newCollection.Add(currentViewModel.CurrentContent.SelectedSeries);
                        _seriesCollection = newCollection;
                        _storageSerializer.Save(new Storage(_counter.GetIdWithOutIncrease(), newCollection));
                        _mainViewModel.CurrentViewModel = new EntryListViewModel(newCollection, this);
                        break;
                    }
                    throw new InvalidCastException($"UpdateViewCommand.Execute: Add_Ok ({_mainViewModel.CurrentViewModel.GetType()})");
                case UpdateView.Add_Cancel:
                    _mainViewModel.CurrentViewModel = new EntryListViewModel(_seriesCollection, this);
                    break;
                //case UpdateView.Edit_Delete:
                    //if (_mainViewModel.CurrentViewModel is EntryViewModel currentViewModel)
                    //{
                    //    var newCollection = _seriesCollection.ToOvservableCollection();
                    //    newCollection.Delete(currentViewModel.SelectedSeries);
                    //    _seriesCollection = newCollection;
                    //    _storageSerializer.Save(new Storage(_counter.GetIdWithOutIncrease(), newCollection));
                    //    _mainViewModel.CurrentViewModel = new EntryListViewModel(newCollection, this);
                    //    break;
                    //}
                    //throw new InvalidCastException($"UpdateViewCommand.Execute: Edit_Delete ({_mainViewModel.CurrentViewModel.GetType()})");
                default:
                    throw new NotImplementedException($"UpdateViewCommand.Execute: Unknown parameter ({parameter})");
            }
        }
    }
}
