using FeedReader.App.Dtos;
using System.Collections.Generic;

namespace FeedReader.App.Mappers
{
    internal interface IWolverhamptonMapper
    {
        List<string> MapHorses(WolverhamptonRaceDto wolverhamptonRace);
    }
}