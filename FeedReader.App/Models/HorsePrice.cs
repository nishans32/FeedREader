using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FeedReader.App.Models
{
    public class HorsePrice
    {
        [XmlAttribute("number")]
        public int Number { get; set; }

        [XmlAttribute("Price")]
        public decimal Price { get; set; }
    }

}
