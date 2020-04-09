using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Watchlist
{
    internal class SaveData
    {
        //private string path = "C:\\Users\\Seischen\\Documents\\Projekte\\Watchlist";
        private string path = "C:\\Users\\Seischen\\Documents\\watchlistData.xml";
        private readonly XmlFile xmlFile;

        public SaveData(XmlFile xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        internal IEnumerable<Series> Load()
        {
            return xmlFile.Read<List<Series>>(path);
        }

        internal void Save(IEnumerable<Series> series)
        {
            xmlFile.Save(path, series);
        }
    }
}
