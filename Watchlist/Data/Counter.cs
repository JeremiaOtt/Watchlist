using System;
using System.Collections.Generic;
using System.Text;

namespace Watchlist
{
    public class Counter
    {
        private int id;

        public int Id => id++;

        public Counter()
        {
            id = 0;
        }
    }
}
