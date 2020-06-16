using System.Collections.ObjectModel;
using Watchlist.ViewModels.Interfaces;

namespace Watchlist.ViewModels
{
    public class MainViewModel : IViewModel
    {
        private readonly SeriesSerializer Serializer;
        private readonly ObservableCollection<Series> Series;   // IEnumerable?
        public IViewModel CurrentView { get; private set; }


        public MainViewModel(XmlSerializer xmlFile)
        {
            Series = new ObservableCollection<Series>();
            Serializer = new SeriesSerializer(xmlFile);
            Load();
            CurrentView = new EntryListViewModel(Series);

            // Testing
            //var name = "Log Horizon";
            //var watched = false;
            //Series.Add(new Series(new Counter(), name, watched));
        }

        // Save and Load as an extern methode? So I can use it in other ViewModels as well.
        // RelayCommand? https://www.youtube.com/watch?v=8WfD2cFRymM&list=PLKShHgmYjjFwmuUZ46GxeSTA2zKZF-8nv&index=4
        public void Save()
        {
            Serializer.Save(Series);
        }

        public void Load()
        {
            //Series.Clear();   // I think I should be carefull with this Command
            foreach (var dataEntry in Serializer.Load())
                Series.Add(dataEntry);
        }
    }
}
