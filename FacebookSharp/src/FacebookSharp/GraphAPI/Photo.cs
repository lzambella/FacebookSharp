using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI
{
    public class Photo
    {
        [JsonProperty("data")]
        public IList<PhotoNode> PhotoNodes { get; set; }
        [JsonProperty("paging")]
        public object Paging { get; set; }
    }
}
