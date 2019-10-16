using Newtonsoft.Json;
using System;

namespace FeedReader.App.Parsers
{

    public class JsonParser : IParser
    {
        public SourceType SourceType => SourceType.Json;

        public object Parse(string file, Type type)
        {
            return JsonConvert.DeserializeObject(file, type);
        }
    }
}