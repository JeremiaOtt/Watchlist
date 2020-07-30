using System.Windows.Input;

namespace Watchlist.ViewModels
{
    public class ShowEntryListViewModel : BaseViewModel
    {
        public EntryListViewModel Content { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        public ShowEntryListViewModel(EntryListViewModel content, ICommand updateViewCommand)
        {
            Content = content;
            UpdateViewCommand = updateViewCommand;
        }
    }
}
