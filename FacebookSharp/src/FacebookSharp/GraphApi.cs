using System.IO;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI;
using FacebookSharp.GraphAPI.Fields;
using Newtonsoft.Json;

namespace FacebookSharp
{
    /// <summary>
    /// Main object, contains all the top level objects (user, page, photo, etc.)
    /// </summary>
    public class GraphApi
    {
        /// <summary>
        /// Determines which api version to use
        /// </summary>
        public enum ApiVersion
        {
            TwoEight,
        }

        public static string Token { get; set; }
        public ApiVersion Version { get; set; }

        public GraphApi(string token, ApiVersion version)
        {
            Token = token;
            Version = version;
        }
        /// <summary>
        /// Gets the string value of the API version contained in Version
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            switch (Version)
            {
                case ApiVersion.TwoEight:
                    return "v2.8";
            }
            return "";
        }
        /// <summary>
        /// Get a User's ID and name
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns></returns>
        public async Task<User> GetUser(string id)
        {
            var json = await GetJson(id);
            return JsonConvert.DeserializeObject<User>(json);
        }

        /// <summary>
        /// Gets a User
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="fields">Fields to grab from</param>
        /// <returns></returns>
        public async Task<User> GetUser(string id, ApiField fields)
        {
            var json = await GetJson(id, fields);
            return JsonConvert.DeserializeObject<User>(json);
        }

        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns>Page object, by default returns all fields</returns>
        public async Task<Page> GetPage(string id)
        {
            var http = $"https://graph.facebook.com/v2.8/{id}?access_token={Token}";
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
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <param name="fields">fields to get from</param>
        /// <returns>Page object</returns>
        public async Task<Page> GetPage(string id, ApiField fields)
        {
            var json = await GetJson(id, fields);
            return JsonConvert.DeserializeObject<Page>(json);
        }



        private async Task<string> GetJson(string id)
        {
            var http = $"https://graph.facebook.com/{GetVersion()}/{id}?access_token={Token}";
            var request = WebRequest.Create(http);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                return json;
            }
        }

        private async Task<string> GetJson(string id, ApiField fields)
        {
            var http = $"https://graph.facebook.com/{GetVersion()}/{id}?access_token={Token}&{fields.GenerateFields()}";
            var request = WebRequest.Create(http);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                return json;
            }
        }
    }

}
