using FeedReader.App.Dtos;
using FeedReader.App.Mappers;
using FeedReader.App.Models;
using FeedReader.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedReader.App.Parsers
{
    public class RaceParserStrategy
    {
        //Use DI to inject the implementations
        //private ParserStrategy _parserStrategy;
        private IEnumerable<IParser> _parserStrategy;
        private IEnumerable<IRaceMapper> _raceMapperStrategy;

        public RaceParserStrategy()
        {
            //Use DI to inject the implementations through constructor
            _parserStrategy = new List<IParser> {
                new JsonParser(),
                new XmlParser()
            };
        }

        public IEnumerable<HorseData> Read(RaceLocation race, FeedSettings feedSettings)
        {
            var config = feedSettings.RaceConfigs.FirstOrDefault(v => v.Location == race);

            var raceType = Type.GetType(config.Location.ToString());
            var raceDto = _parserStrategy.FirstOrDefault(v => v.SourceType == config.Type).Parse(config.Source, raceType);

            // TODO: AutoMapper map from whatever to whatver
            return _raceMapperStrategy.FirstOrDefault(v => v.Location == config.Location).Map((Race)raceDto);
        }
    }
}