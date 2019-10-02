using System.Collections.Generic;

namespace FeedReader.App
{
    internal interface IWolverhamptonMapper
    {
        List<string> MapHorses(WolverhamptonRace wolverhamptonRace);
    }
}