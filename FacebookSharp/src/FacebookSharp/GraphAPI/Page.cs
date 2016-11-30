using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI
{
    /// <summary>
    /// This represents a Facebook Page.
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Page ID. No access token is required to access this field
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Information about the Page
        /// </summary>
        [JsonProperty("about")]
        public string About { get; set; }
        /// <summary>
        /// The access token you can use to act as the Page. Only visible to Page Admins. If your business requires two-factor authentication, and the person hasn't authenticated, this field may not be returned
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// The Page's currently running promotion campaign
        /// </summary>
        [JsonProperty("ad_campaign")]
        public AdCampaign AdCampaign { get; set; }
        [JsonProperty("affilition")]
        public string Affilition { get; set; }
        [JsonProperty("app_id")]
        public string Appid { get; set; }
        //TODO: Implement AppLinks object
        [JsonProperty("app_links")]
        public object AppLinks { get; set; }
        [JsonProperty("artists_we_like")]
        public string ArtistsWeLike { get; set; }
        [JsonProperty("attire")]
        public string Attire { get; set; }
        [JsonProperty("awards")]
        public string Awards { get; set; }
        [JsonProperty("band_interests")]
        public string BandInterests { get; set; }
        [JsonProperty("band_members")]
        public string BandMembers { get; set; }
        [JsonProperty("best_page")]
        public Page BestPage { get; set; }
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("birthday")]
        public string Birthday { get; set; }
        [JsonProperty("booking_agent")]
        public string BookingAgent { get; set; }
        //TODO: Is this a business object?
        [JsonProperty("business")]
        public Business Business { get; set; }
        [JsonProperty("can_checkin")]
        public bool CanCheckin { get; set; }
        [JsonProperty("can_post")]
        public bool CanPost { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        //TODO: implement PageCategory
        [JsonProperty("category_list")]
        public object CategoryList { get; set; }
        //TODO: finish implementing Page

    }
}
