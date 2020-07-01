using System.Collections.Generic;
using Watchlist.Models;
using Watchlist.ViewModels;

namespace Watchlist.Data
{
    public class Manager
    {
        //private readonly SeriesSerializer _serializer;
        //private readonly Counter _counter;

        //public MainViewModel MainView { get; }

        //public Manager(XmlSerializer xmlFile)
        //{
        //    //_serializer = new SeriesSerializer(xmlFile); // Inject Serializer direct
        //    //_counter = new Counter(10); // ToDo: Save counter current Id too
        //    //MainView = new MainViewModel(Load(), ViewNewEntry);
        //}

        // Save and Load as an extern methode? So I can use it in other ViewModels as well.
        // ICommand? https://www.youtube.com/watch?v=8WfD2cFRymM&list=PLKShHgmYjjFwmuUZ46GxeSTA2zKZF-8nv&index=4
        //private void Save(IEnumerable<Series> series)
        //{
        //    _serializer.Save(series);
        //}

        //private IEnumerable<Series> Load()
        //{
        //    return _serializer.Load();
        //}

        //private void ViewNewEntry(IEnumerable<Series> series)
        //{
        //    MainView.CurrentViewModel = new EntryViewModel(series, new Series(_counter, "Enter new name"));
        //}
    }
}
