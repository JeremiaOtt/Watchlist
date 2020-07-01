using System.Collections.Generic;
using Watchlist.Models;

namespace Watchlist
{
    public class SeriesSerializer
    {
        // ToDo: The path should come from the outsite
        //private string path = "C:\\Users\\Seischen\\Documents\\Projekte\\Watchlist";
        private string path = "C:\\Users\\Seischen\\Documents\\watchlistData.xml";

        private readonly XmlSerializer xmlFile;

        public SeriesSerializer(XmlSerializer xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        public IEnumerable<Series> Load()
        {
            return xmlFile.Read<List<Series>>(path);
        }

        public void Save(IEnumerable<Series> series)
        {
            xmlFile.Save(path, series);
        }
    }
}
