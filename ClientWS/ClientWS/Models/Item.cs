using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ClientWS.Models
{
    public class Item
    {
        [XmlElement("ItemType")]
        public string ItemType { get; set; }

        [XmlElement("ItemValue")]
        public string ItemValue { get; set; }

    }
}