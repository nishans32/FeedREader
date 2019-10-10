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
        private readonly IXmlParser _xmlParser;
        private readonly IJsonParser _jsonParser;
        private readonly IWolverhamptonMapper _wolverhamptonMapper;
        private readonly ICaufieldMapper _caufieldMapper;
        private readonly string wolverhamptonFileLoc;
        private readonly string caufieldFileLoc;
        private IWolverhamptonService _wolverhamptonService;
        private CaulfieldService _caulfieldService;


        public RaceParserService(IXmlParser xmlParser, IJsonParser jsonParser, 
            IWolverhamptonMapper wolverhamptonMapper, ICaufieldMapper caufieldMapper,
            IOptions<FeedSettings> settings)
        {
            _jsonParser = jsonParser;
            _wolverhamptonMapper = wolverhamptonMapper;
            _caufieldMapper = caufieldMapper;
            wolverhamptonFileLoc = settings.Value.WolverhapmtonFileLocation;
            caufieldFileLoc = settings.Value.CaufieldFileLoc;
        }

        public List<string> GetHorseData()
        {
            var wolverhaptonData = File.ReadAllText(wolverhamptonFileLoc);

            var wolverhamptonHorses = _wolverhamptonService.GetHorses(wolverhaptonData);

            var caulfieldData = File.ReadAllText(caufieldFileLoc);

            var caufieldHorses = _caulfieldService.GetHorses(caulfieldData);


            var horses = new List<string>();
            horses.AddRange(wolverhamptonHorses);
            horses.AddRange(caufieldHorses);

            return horses;
        }
    }

