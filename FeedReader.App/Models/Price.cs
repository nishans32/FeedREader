using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FeedReader.App.Models
{
    public class Price
    {
        [XmlArray(ElementName = "horses")]
        [XmlArrayItem(ElementName = "horse")]
        public HorsePrice[] Horses { get; set; }
    }

}
