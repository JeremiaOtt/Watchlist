using System;
using System.Collections.Generic;
using System.Text;

namespace Watchlist
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Watched { get; set; }

        // Needed for Xmlseriallizer class
        public Series()
        {

        }

        public Series(Counter counter, string name, bool watched = false)
        {
            if (counter == null)
                throw new ArgumentNullException("Series counter is null");

            Id = counter.Id;
            Name = name;
            Watched = watched;
        }
    }
}
