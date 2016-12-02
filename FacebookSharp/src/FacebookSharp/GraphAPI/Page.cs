using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        [JsonProperty("checkins")]
        public uint CheckIns { get; set; }
        [JsonProperty("company_overview")]
        public string CompanyOverview { get; set; }
        // TODO: implement MailingAddress
        [JsonProperty("contact_address")]
        public object MailingAddress { get; set; }
        [JsonProperty("context")]
        public object Context { get; set; }
        [JsonProperty("cover")]
        public object Cover { get; set; }
        [JsonProperty("culinary_team")]
        public string CulinaryTeam { get; set; }
        [JsonProperty("current_location")]
        public string CurrentLocation { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }
        [JsonProperty("directed_by")]
        public string DirectedBy { get; set; }
        [JsonProperty("display_subtext")]
        public string DisplaySubtext { get; set; }
        [JsonProperty("displayed_message_response_time")]
        public string DisplayedMessageRespponseTime { get; set; }
        [JsonProperty("emails")]
        public IList<string> Emails { get; set; }
        [JsonProperty("engagement")]
        public object Engagement { get; set; }
        [JsonProperty("fan_count")]
        public uint FanCount { get; set; }
        [JsonProperty("featured_video")]
        public object FeaturedVideo { get; set; }
        [JsonProperty("features")]
        public string Features { get; set; }
        [JsonProperty("food_styles")]
        public IList<string> FoodStyles { get; set; }
        [JsonProperty("founded")]
        public string Founded { get; set; }
        [JsonProperty("general_info")]
        public string GeneralInfo { get; set; }
        [JsonProperty("general_manager")]
        public string GeneralManager { get; set; }
        [JsonProperty("genre")]
        public string Genre { get; set; }
        [JsonProperty("global_brand_page_name")]
        public string GlobalBrandPageName { get; set; }
        [JsonProperty("global_brand_root_id")]
        public string GlobalBrandRootId { get; set; }
        [JsonProperty("has_added_app")]
        public bool HasAddedApp { get; set; }
        [JsonProperty("hometown")]
        public string Hometown { get; set; }
        [JsonProperty("hours")]
        public IDictionary<string, string> Hours { get; set; }
        [JsonProperty("impressum")]
        public string Impressum { get; set; }
        [JsonProperty("influences")]
        public string Influences { get; set; }

        //TODO: finish implementing Page

    }
}
