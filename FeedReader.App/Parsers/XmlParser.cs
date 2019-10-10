namespace FeedReader.App.Parsers
{
    public interface IXmlParser
    {
        T Parse<T>(string wolverhamptonXml);
    }

    public class XmlParser: IXmlParser
    {
        public T Parse<T>(string wolverhamptonXml)
        {
            
        }
    }
}