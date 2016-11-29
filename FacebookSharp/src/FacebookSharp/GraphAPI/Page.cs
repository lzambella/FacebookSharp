using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string id { get; set; }
        /// <summary>
        /// Information about the Page
        /// </summary>
        public string about { get; set; }
        /// <summary>
        /// The access token you can use to act as the Page. Only visible to Page Admins. If your business requires two-factor authentication, and the person hasn't authenticated, this field may not be returned
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// The Page's currently running promotion campaign
        /// </summary>
        public AdCampaign ad_campaign { get; set; }

        public string affilition { get; set; }
        public string app_id { get; set; }
        //TODO: Implement AppLinks object
        public object app_links { get; set; }
        public string artists_we_like { get; set; }
        public string attire { get; set; }
        public string awards { get; set; }
        public string band_interests { get; set; }
        public string band_members { get; set; }
        public Page best_page { get; set; }
        public string bio { get; set; }
        public string birthday { get; set; }
        public string booking_agent { get; set; }
        //TODO: Is this a business object?
        public Business business { get; set; }
        public bool can_checkin { get; set; }
        public bool can_post { get; set; }
        public string category { get; set; }
        //TODO: implement PageCategory
        public object category_list { get; set; }
        //TODO: finish implementing Page

    }
}
