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
            TwoEight,
        }
        /// <summary>
        /// Graph API Token
        /// </summary>
        private string Token { get; set; }
        /// <summary>
        /// API version to use
        /// </summary>
        private ApiVersion Version { get; set; }
        /// <summary>
        /// Create a new GraphApi object that allows
        /// use of the Facebook API
        /// </summary>
        /// <param name="token">Graph API token</param>
        public GraphApi(string token, ApiVersion version)
        {
            Token = token;
            Version = version;
        }
        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns>Page object containing only the username and id</returns>
        public async Task<Page> GetPage(string id)
        {
            //TODO: Api appears to only return the user name and id, find out how to add all the other parameters defined in the Page documentation
            var http = "";
            switch (Version)
            {
                case ApiVersion.TwoEight:
                    http = $"https://graph.facebook.com/v2.8/{id}?access_token={Token}";
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
        /// <summary>
        /// Gets an edge of a Page (ie. photos and videos)
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="edge">Edge to get</param>
        /// <returns></returns>
        public async Task<Page> GetPage(string id, PageEdge edge)
        {
            return null;
        }
    }
}
