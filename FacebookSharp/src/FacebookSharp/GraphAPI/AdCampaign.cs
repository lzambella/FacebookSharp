using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    /// <summary>
    /// An ad set is a group of ads that share the same daily or lifetime budget, schedule, bid type, bid info, and targeting data. Ad sets enable you to group ads according to your criteria, and you can retrieve the ad-related statistics that apply to a set.
    /// Prior to July 2014 ad sets were referred to as 'campaigns'. When using ad sets in API calls the parameter may be referred to as 'adcampaign'. A campaign contains one or more ad sets.
    /// </summary>
    public class AdCampaign
    {
        public enum ConfiguredStatus
        {
            ACTIVE,
            PAUSED,
            DELETED,
            ARCHIVE
        }

        public enum EffectiveStatus
        {
            ACTIVE, PAUSED, DELETED, PENDING_REVIEW, DISAPPROVED, PREAPPROVED, PENDING_BILLING_INFO, CAMPAIGN_PAUSED, ARCHIVED, ADSET_PAUSED
        }

        public enum Status
        {
            ACTIVE, PAUSED, DELETED, ARCHIVED
        }
        /// <summary>
        /// Ad set ID
        /// </summary>
        string id { get; set; }
        /// <summary>
        /// Ad Account ID
        /// </summary>
        string account_id { get; set; }
        public IList<AdLabel> adlabels { get; set; }
        public List<AdStudy> brand_lift_studies { get; set; }
        public bool budget_rebalance_flag { get; set; }
        public string buying_type { get; set; }
        public bool can_create_brand_lift_study { get; set; }
        public bool can_use_spend_cap { get; set; }
        public ConfiguredStatus configured_status { get; set; }
        public string created_time { get; set; }
        public EffectiveStatus effective_status { get; set; }
        public string name { get; set; }
        public string objective { get; set; }
        public IList<AdRecommendation> recommendations { get; set; }
        public string spend_cap { get; set; }
        public string start_time { get; set; }
        public Status status { get; set; }
        public string stop_time { get; set; }
        public string updated_time { get; set; }

    }
}
