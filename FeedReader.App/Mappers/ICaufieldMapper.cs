using FeedReader.App.Dtos;
using System.Collections.Generic;

namespace FeedReader.App.Mappers
{
    public interface ICaufieldMapper
    {
        List<string> MapHorses(CaufieldRaceDto caufieldRace);
    }
}