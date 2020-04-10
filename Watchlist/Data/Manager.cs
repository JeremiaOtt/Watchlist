using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Watchlist.Emum;

namespace Watchlist
{
    internal class Manager
    {
        public Page CurrentPage { get; set; }
        public ObservableCollection<Series> Series { get; }
        private readonly SaveData saveData;

        public Manager(XmlFile xmlFile)
        {
            CurrentPage = Page.EntryList;
            Series = new ObservableCollection<Series>();
            saveData = new SaveData(xmlFile);
            Load();

            // Testing
            //var name = "Log Horizon";
            //var watched = false;
            //Series.Add(new Series(new Counter(), name, watched));
        }

        internal void AddEntry()
        {
            //Testing
            var name = "Naruto";
            var watched = true;
            Series.Add(new Series(new Counter(), name, watched));
            //Save();

            CurrentPage = Page.EntryView;
        }

        internal void ViewEntryList()
        {
            CurrentPage = Page.EntryList;
        }

        internal void Save()
        {
            saveData.Save(Series);
        }

        internal void Load()
        {
            foreach (var data in saveData.Load())
                Series.Add(data);
        }
    }
}
