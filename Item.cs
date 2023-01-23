using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Module2PracticeQuestion
{
	public class Item
	{


        [XmlAttribute("id")]
        public string? id { get; set; }


        [XmlAttribute("label")]
        public string? label { get; set; }

       

    }
}

