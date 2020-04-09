using System.IO;
using System.Xml.Serialization;

namespace Watchlist
{
    public class XmlFile
    {
        public void Save(string path, object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);

            File.WriteAllText(path, writer.ToString());
        }

        public T Read<T>(string path) where T : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            if (!File.Exists(path))
                return new T();

            string xmlText = File.ReadAllText(path);
            return (T)serializer.Deserialize(new StringReader(xmlText));
        }
    }
}
