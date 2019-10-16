using FeedReader.App.Dtos;
using FeedReader.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedReader.App.Mappers
{
    public interface IRaceMapper
    {
        RaceLocation Location { get; }
        IEnumerable<HorseData> Map(Race race);
    }
}
