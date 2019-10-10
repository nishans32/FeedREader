using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FeedReader.App.Models
{
    public class Race
    {
        [XmlArray(ElementName = "horses")]
        [XmlArrayItem(ElementName = "horse")]
        public Horse[] Horses { get; set; }

        [XmlArray(ElementName = "prices")]
        [XmlArrayItem(ElementName = "price")]
        public HorsePrices[] Prices { get; set; }
    }

}
