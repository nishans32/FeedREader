using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace FeedReader.App.Parsers
{
    public class XmlParser : IParser
    {
        public SourceType SourceType => SourceType.Xml;

        public object Parse(string file, Type type)
        {
            var xmlSerializer = new XmlSerializer(type);

            using (var fileStream = new FileStream(file, FileMode.Open))
            {
                return xmlSerializer.Deserialize(fileStream);
            }

        }
    }
}