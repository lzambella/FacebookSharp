using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI;
using FacebookSharp.GraphAPI.Fields;
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
        public string Token { get; set; }
        /// <summary>
        /// API version to use
        /// </summary>
        public ApiVersion Version { get; set; }
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
        /// Gets the string value of the API version contained in Version
        /// </summary>
        /// <returns></returns>
        private string GetVersion()
        {
            switch (Version)
            {
                case ApiVersion.TwoEight:
                    return "v2.8";
            }
            return "";
        }
    }
}
