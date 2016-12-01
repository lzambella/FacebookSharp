using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI
{
    public class PhotoNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("album")]
        public Album PhotoAlbum { get; set; }
        [JsonProperty("backdated_time")]
        public string BackdatedTime { get; set; }
        [JsonProperty("backdated_time_granularity")]
        public int BackdatedTimeGranularity { get; set; }
        [JsonProperty("can_backdate")]
        public bool CanBackdate { get; set; }
        [JsonProperty("can_delete")]
        public bool CanDelete { get; set; }
        [JsonProperty("can_tag")]
        public bool CanTag { get; set; }
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }
        [JsonProperty("event")]
        public Event AssociatedEvent { get; set; }
        [JsonProperty("from")]
        public User From { get; set; }


    }
}
