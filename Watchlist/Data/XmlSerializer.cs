﻿using System.IO;

namespace Watchlist
{
    public class XmlSerializer
    {
        public void Save(string path, object obj)
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(obj.GetType());

            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);

            File.WriteAllText(path, writer.ToString());
        }

        public T Read<T>(string path) where T : new()
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(T));

            if (!File.Exists(path))
                return new T();

            string xmlText = File.ReadAllText(path);
            return (T)serializer.Deserialize(new StringReader(xmlText));
        }
    }
}
