using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FeedReader.App.Models
{
    public class HorsePrices
    {
        [XmlArray(ElementName = "horses")]
        [XmlArrayItem(ElementName = "horse")]
        public HorsePrice[] HorsePrice { get; set; }
    }

}
