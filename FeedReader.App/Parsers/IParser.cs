using System;
using System.Collections.Generic;
using System.Text;

namespace FeedReader.App.Parsers
{
    public interface IParser
    {
        SourceType SourceType { get; }
        object Parse(string file, Type type);
    }
}
