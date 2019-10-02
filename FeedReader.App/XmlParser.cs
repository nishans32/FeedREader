namespace FeedReader.App
{
    public interface IXmlParser
    {
        T Parse<T>();
    }
}