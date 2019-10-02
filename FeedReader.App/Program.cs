using System;

namespace FeedReader.App
{
    class Program
    {
        private static readonly object _xmlParser;
        private static readonly IRaceParserService _raceParserService;

        static void Main(string[] args)
        {
            var horses = _raceParserService.GetHorseData();
        }
    }
}
