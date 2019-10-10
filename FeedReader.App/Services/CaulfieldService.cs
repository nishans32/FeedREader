using System;
using System.Collections.Generic;
using System.Text;
using FeedReader.App.Dtos;
using FeedReader.App.Mappers;
using FeedReader.App.Parsers;

namespace FeedReader.App.Services
{
    public interface ICaulfieldService
    {

    }

    public class CaulfieldService:ICaulfieldService
    {
        private readonly IXmlParser _xmlParser;
        private readonly IJsonParser _jsonParser;
        private readonly ICaufieldMapper _caufieldMapper;

        public CaulfieldService(IXmlParser xmlParser, IJsonParser jsonParser, ICaufieldMapper caufieldMapper)
        {
            _xmlParser = xmlParser;
            _jsonParser = jsonParser;
            _caufieldMapper = caufieldMapper;
        }

        public List<string> GetHorses(string caulfieldData)
        {
            var _caufieldRace = _jsonParser.Parse<CaufieldRaceDto>(caulfieldData);

            return _caufieldRace != null
                ? _caufieldMapper.MapHorses(_caufieldRace)
                : new List<string>();

        }
    }


}
