namespace Watchlist
{
    public class Counter
    {
        private int _id;

        public int Id => _id++;

        public Counter(int id)
        {
            _id = id;
        }

        public int GetIdWithOutIncrease() => _id;
    }
}
