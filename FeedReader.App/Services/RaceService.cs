using FeedReader.App.Dtos;
using FeedReader.App.Models;
using FeedReader.App.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedReader.App.Services
{
    public class RaceService
    {
        private FeedSettings _feedSettings;

        public RaceService()
        {
            _feedSettings = new FeedSettings(); //Again, can be read from config and injected
        }

        public IEnumerable<HorseData> GetAll()
        {
            var raceParserStrategy = new RaceParserStrategy();

            var races = new[] { RaceLocation.Caulfield, RaceLocation.Wolverhampton };

            List<HorseData> horseRaces = new List<HorseData>();
            foreach(var race in races)
            {
                horseRaces.Concat(raceParserStrategy.Read(race, _feedSettings));
            }
            
            return horseRaces;
        }
    }
}
