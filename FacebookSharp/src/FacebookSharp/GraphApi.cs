using System.IO;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI;
using Newtonsoft.Json;

namespace FacebookSharp
{
    public class GraphApi
    {
        /// <summary>
        /// Determines which api version to use
        /// </summary>
        public enum ApiVersion
        {
            TWO_EIGHT,
        }
        private string _token { get; set; }
        private ApiVersion _version { get; set; }
        /// <summary>
        /// Create a new GraphApi object that allows
        /// use of the Facebook API
        /// </summary>
        /// <param name="token">Graph API token</param>
        public GraphApi(string token, ApiVersion version)
        {
            _token = token;
            _version = version;
        }
        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns></returns>
        public async Task<Page> GetPage(string id)
        {
            //TODO: Api appears to only return the user name and id, find out how to add all the other parameters defined in the Page documentation
            var http = "";
            switch (_version)
            {
                case ApiVersion.TWO_EIGHT:
                    http = $"https://graph.facebook.com/v2.8/{id}?access_token={_token}";
                    break;
            }
            var request = WebRequest.Create(http);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<Page>(json);
                return data;
            }
        }
    }
}
