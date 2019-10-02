using Newtonsoft.Json;

namespace FeedReader.App.Parsers
{
    public interface IJsonParser
    {
        T Parse<T>(string caulfieldJson);
    }

    public class JsonParser : IJsonParser
    {
        public T Parse<T>(string caulfieldJson)
        {
            return JsonConvert.DeserializeObject<T>(caulfieldJson);
        }
    }
}