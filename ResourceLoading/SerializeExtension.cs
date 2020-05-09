using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ResourceLoading
{
    public static class SerializeExtension
    {
        public static string SerializeToString(this object obj)
        {
            var xmlSerializer = new XmlSerializer(obj.GetType());
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }

        public static T DeserializeString<T>(this string sourceString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var stringReader = new StringReader(sourceString);
            return (T)xmlSerializer.Deserialize(stringReader);
        }
    }
}
