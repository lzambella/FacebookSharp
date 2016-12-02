using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI
{
    public class User
    {
        /// <summary>
        /// The id of this person's user account. This ID is unique to each app and cannot be used across different apps. 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Equivalent to the bio field
        /// </summary>
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
