using System;
using System.Collections.Generic;
using System.Text;

namespace Watchlist.Models
{
    public class Series
    {
        // I think "set" is needed for Xmlseriallizer class
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Watched { get; set; }

        /// <summary>
        /// Needed for Xmlseriallizer class (Do not use this)
        /// </summary>
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
