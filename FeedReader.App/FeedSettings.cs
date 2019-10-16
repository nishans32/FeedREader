using FeedReader.App.Dtos;
using FeedReader.App.Parsers;
using System.Collections.Generic;

namespace FeedReader.App.Services
{
    public class FeedSettings
    {
        public IEnumerable<RaceConfig> RaceConfigs
        {
            get
            {
                return new List<RaceConfig>{
                    new RaceConfig()
                    {
                        Location = RaceLocation.Wolverhampton,
                        Source = "ilelocforwol.json",
                        Type = SourceType.Json //Supposingly during deserialization from config can convert straight to enum from string
                    },
                    new RaceConfig()
                    {
                        Location = RaceLocation.Caulfield,
                        Source = "ilelocforwol.xml",
                        Type = SourceType.Xml //Supposingly during deserialization from config can convert straight to enum from string
                    }
                };
            }
        }
           
       
        public class RaceConfig
        {
            public RaceLocation Location { get; set; }
            public string Source { get; set; }
            public SourceType Type { get; set; }
        }
        
    }
}