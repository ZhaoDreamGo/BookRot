using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookSearchBot.Models
{
    public class SearchResponse
    {
        [XmlElement("total")]
        public int TotalResults { get; set; }

        [XmlElement("item")]
        //public SearchResults Results { get; set; }
        public List<WorkItem> Results { get; set; }
        //public List<WorkItem> WorkItem { get; set; }
    }
}
