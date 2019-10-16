using FeedReader.App.Dtos;
using FeedReader.App.Mappers;
using FeedReader.App.Parsers;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Options;

namespace FeedReader.App.Services
{
    public interface IRaceParserService
    {
        List<string> GetHorseData();
    }

    public class RaceParserService : IRaceParserService
    {
        //private readonly XmlParser _xmlParser;
        //private readonly IParser _fileParserStrategy;
        //private readonly IWolverhamptonMapper _wolverhamptonMapper;
        //private readonly ICaufieldMapper _caufieldMapper;
        //private readonly string wolverhamptonFileLoc;
        //private readonly string caufieldFileLoc;


        //public RaceParserService(XmlParser xmlParser, IParser fileParserStrategy, 
        //    IWolverhamptonMapper wolverhamptonMapper, ICaufieldMapper caufieldMapper,
        //    IOptions<FeedSettings> settings)
        //{
        //    _xmlParser = xmlParser;
        //    _fileParserStrategy = fileParserStrategy;
        //    _wolverhamptonMapper = wolverhamptonMapper;
        //    _caufieldMapper = caufieldMapper;
        //}

        public List<string> GetHorseData()
        {
            //var wolverhaptonJson = File.ReadAllText(wolverhamptonFileLoc);

            //var caulfieldJson = File.ReadAllText(caufieldFileLoc);

            //var _wolverhamptonRace = _xmlParser.Parse<WolverhamptonRace>(wolverhaptonJson);

            //var _caufieldRace = _jsonParser.Parse<CaufieldRace>(caulfieldJson);

            //var wolverhamptonHorses = _wolverhamptonMapper.MapHorses(_wolverhamptonRace);

            //var caufieldHorses = _caufieldMapper.MapHorses(_caufieldRace);

            //var horses = new List<string>();
            //horses.AddRange(wolverhamptonHorses);
            //horses.AddRange(caufieldHorses);

            //return horses;
            return null;
        }
    }


}