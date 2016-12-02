using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }

}
