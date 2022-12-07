using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookSearchBot.Models
{
    [XmlRoot("rss")]
    public class GoodReadsResponse
    {
        [XmlElement("channel")]
        public SearchResponse Search { get; set; }
    }
}
