using FeedReader.App.Dtos;
using FeedReader.App.Mappers;
using FeedReader.App.Parsers;
using System.Collections.Generic;

namespace FeedReader.App.Services
{
    public interface IRaceParserService
    {
        List<string> GetHorseData();
    }

    public class RaceParserService : IRaceParserService
    {
        private readonly IXmlParser _xmlParser;
        private readonly IJsonParser _jsonParser;
        private readonly IWolverhamptonMapper _wolverhamptonMapper;
        private readonly ICaufieldMapper _caufieldMapper;

        public List<string> GetHorseData()
        {
            var _wolverhamptonRace = _xmlParser.Parse<WolverhamptonRaceDto>();

            var _caufieldRace = _jsonParser.Parse<CaufieldRaceDto>();

            var wolverhamptonHorses = _wolverhamptonMapper.MapHorses(_wolverhamptonRace);

            var caufieldHorses = _caufieldMapper.MapHorses(_caufieldRace);

            var horses = new List<string>();
            horses.AddRange(wolverhamptonHorses);
            horses.AddRange(caufieldHorses);

            return horses;
        }
    }


}