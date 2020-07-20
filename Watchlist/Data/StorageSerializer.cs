using Watchlist.Models;

namespace Watchlist
{
    public class StorageSerializer
    {
        private readonly string _path;
        private readonly XmlSerializer _xmlFile;

        public StorageSerializer(XmlSerializer xmlFile, string path)
        {
            _xmlFile = xmlFile;
            _path = path;
        }

        public Storage Load()
        {
            return _xmlFile.Read<Storage>(_path);
        }

        public void Save(Storage series)
        {
            _xmlFile.Save(_path, series);
        }
    }
}
