using System.Collections.Generic;

namespace FeedReader.App
{
    public interface ICaufieldMapper
    {
        List<string> MapHorses(CaufieldRace caufieldRace);
    }
}