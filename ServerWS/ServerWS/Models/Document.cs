using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ServerWS.Models
{
    public class Document
    {
        [XmlElement("Authentication")]
        public Authentication Authentication { get; set; }

        [XmlElement("Items")]
        public List<Items> Items { get; set; }
        
    }
}