namespace FeedReader.App.Parsers
{
    internal interface IJsonParser
    {
        T Parse<T>();
    }
}