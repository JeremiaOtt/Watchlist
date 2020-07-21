using Watchlist.Models;

namespace Watchlist.ViewModels
{
    public class EntryViewModel : BaseViewModel
    {
        public Series SelectedSeries { get; set; }

        public EntryViewModel(Series newSeries)
        {
            SelectedSeries = newSeries;
        }
    }
}
