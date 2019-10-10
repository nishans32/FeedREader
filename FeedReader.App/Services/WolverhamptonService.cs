using System;
using System.Collections.Generic;
using System.Text;
using FeedReader.App.Dtos;
using FeedReader.App.Mappers;
using FeedReader.App.Parsers;

namespace FeedReader.App.Services
{
    public interface IWolverhamptonService
    {
        List<string> GetHorses(string wolverhaptonData);
    }
    public class WolverhamptonService: IWolverhamptonService
    {

        private readonly IXmlParser _xmlParser;
        private readonly IJsonParser _jsonParser;
        private readonly IWolverhamptonMapper _wolverhamptonMapper;

        public WolverhamptonService(IXmlParser xmlParser, IJsonParser jsonParser)
        {
            _xmlParser = xmlParser;
            _jsonParser = jsonParser;
        }

        public List<string> GetHorses(string wolverhaptonData)
        {
            var wolverhamptonRace = _xmlParser.Parse<WolverhamptonRaceDto>(wolverhaptonData);

            return wolverhamptonRace != null ? 
                 _wolverhamptonMapper.MapHorses(wolverhamptonRace)
                : new List<string>();
        }
    }
}
