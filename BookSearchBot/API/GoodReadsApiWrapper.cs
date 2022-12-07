using BookSearchBot.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookSearchBot.API
{
    public class GoodReadsApiWrapper : IApiWrapper
    {
        private HttpClient client;

        public string SearchType { get; set; }

        public GoodReadsApiWrapper()
        {
            client = new HttpClient();
        }

        public async Task<GoodReadsResponse> GetSearchResponse(string input)
        {
            var query = input;
            var baseUrl = "https://openapi.naver.com/v1/search/book.xml?query=" + query;
            var msg = new HttpRequestMessage(HttpMethod.Get, baseUrl);
            msg.Headers.Add("X-Naver-Client-Id", "DofP7RK7FXOoZtcxFckl");
            msg.Headers.Add("X-Naver-Client-Secret", "5fFEMVZ7e9");
            var res = await client.SendAsync(msg);
            var content = await res.Content.ReadAsStringAsync();
            

            var serializer = new XmlSerializer(typeof(GoodReadsResponse));

            using (var stream = new StringReader(content))
            {
                return (GoodReadsResponse)serializer.Deserialize(stream);
            }
        }
    }
}
