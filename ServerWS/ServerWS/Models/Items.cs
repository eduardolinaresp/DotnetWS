using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ServerWS.Models
{
    public class Items
    {

        [XmlElement("LineNumber")]
        public string LineNumber { get; set; }

        [XmlElement("Item")]
        public Item Item { get; set; }

        [XmlElement("ItemQty")]
        public string ItemQty { get; set; }
        
        [XmlElement("PrcItem")]
        public string PrcItem { get; set; }


    }
}