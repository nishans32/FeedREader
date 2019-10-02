namespace FeedReader.App.Parsers
{
    public interface IXmlParser
    {
        T Parse<T>();
    }
}