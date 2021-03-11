using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ClientWS.Models
{
    public class Header
    {
        [XmlElement("date")]
        public string date { get; set; }
        
        [XmlElement("client")]
        public string client { get; set; }

    }
}