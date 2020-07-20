using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Watchlist.Extensions;

namespace Watchlist.Models
{
    public class Storage
    {
        public int? Id { get; set; }

        public ObservableCollection<Series> SeriesCollection { get; set; }

        /// <summary>
        /// Needed for Xmlseriallizer class (Do not use this)
        /// </summary>
        public Storage()
        {

        }

        public Storage(int id, IEnumerable<Series> seriesCollection)
        {
            Id = id;
            SeriesCollection = seriesCollection.ToOvservableCollection();
        }
    }
}
