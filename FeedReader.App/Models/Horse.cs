using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FeedReader.App.Models
{
    public class Horse
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("number")]
        public int Number { get; set; }
    }

}
