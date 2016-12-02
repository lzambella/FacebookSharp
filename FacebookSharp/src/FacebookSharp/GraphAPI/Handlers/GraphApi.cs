using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI.Fields;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI.Handlers
{
    /// <summary>
    /// Every handler should inherit this
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

        public string Token { get; set; }
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
                case PageHandler.ApiVersion.TwoEight:
                    return "v2.8";
            }
            return "";
        }

        public async Task<string> GetJson(string id)
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

        public async Task<string> GetJson(string id, ApiField fields)
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
