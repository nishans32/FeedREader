using FeedReader.App.Dtos;
using FeedReader.App.Models;
using System.Collections.Generic;

namespace FeedReader.App.Mappers
{
    public class CaufieldMapper: IRaceMapper
    {
        public RaceLocation Location => RaceLocation.Caulfield;

        public IEnumerable<HorseData> Map(Race race)
        {
            return new[] { new HorseData(), new HorseData() };
        }
    }
}