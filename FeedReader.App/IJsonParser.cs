namespace FeedReader.App
{
    internal interface IJsonParser
    {
        T Parse<T>();
    }
}