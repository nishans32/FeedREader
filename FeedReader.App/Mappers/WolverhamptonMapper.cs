using FeedReader.App.Dtos;
using FeedReader.App.Models;
using System.Collections.Generic;

namespace FeedReader.App.Mappers
{
    public class WolverhamptonMapper: IRaceMapper
    {
        public RaceLocation Location => RaceLocation.Wolverhampton;

        public IEnumerable<HorseData> Map(Race race)
        {
            return new[] { new HorseData(), new HorseData() };
        }
    }
}