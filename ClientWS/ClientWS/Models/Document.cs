using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ClientWS.Models
{
    public class Document
    {
        [XmlElement("Header")]
        public Header Header { get; set; }

        [XmlElement("Items")]
        public List<Items> Items { get; set; }
        
    }
}