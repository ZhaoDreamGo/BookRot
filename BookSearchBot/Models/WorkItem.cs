using System.Xml.Serialization;

namespace BookSearchBot.Models
{
    public class WorkItem
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("image")]
        public string ImageUrl { get; set; }
        //[XmlElement("item")]
        //public BookItem BookItem { get; set; }
    }
}
//namespace BookSearchBot.Models
//{
//    public class BookItem
//    {
//        [XmlElement("title")]
//        public string Title { get; set; }

//        [XmlElement("author")]
//        public Author Author { get; set; }

//        [XmlElement("image")]
//        public string ImageUrl { get; set; }
//    }
//}