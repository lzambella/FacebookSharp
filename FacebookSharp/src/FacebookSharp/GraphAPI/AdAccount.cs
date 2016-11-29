using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    /// <summary>
    /// An ad account is an account used for managing ads on Facebook.
    /// </summary>
    public class AdAccount
    {
        /// <summary>
        /// The string act_{ad_account_id}
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The ID of the ad account
        /// </summary>
        public string account_id { get; set; }
        /// <summary>
        /// Status of the account 
        /// 1 = ACTIVE
        /// 2 = DISABLED
        /// 3 = UNSETTLED
        /// 7 = PENDING_RISK_REVIEW
        /// 9 = IN_GRACE_PERIOD
        /// 100 = PENDING_CLOSURE
        /// 101 = CLOSED
        /// 102 = PENDING_SETTLEMENT
        /// 201 = ANY_ACTIVE
        /// 202 = ANY_CLOSED
        /// </summary>
        public Int32 account_status { get; set; }
        /// <summary>
        /// Amount of time the ad account has been open, in days
        /// </summary>
        public float age { get; set; }
        /// <summary>
        /// Details of the agency advertising on behalf of this client account, if applicable
        /// </summary>
        public AgencyClientDeclaration agency_client_declaration { get; set; }
        /// <summary>
        /// Current total amount spent by the account. This can be reset.
        /// </summary>
        public string amount_spent { get; set; }
        /// <summary>
        /// The attribution specification of ad account, including click through window length, view through window length, etc.
        /// </summary>
        public IList<object> attribution_spec { get; set; }
        /// <summary>
        /// Bill amount due
        /// </summary>
        public string balance { get; set; }
        /// <summary>
        /// The Business Manager, if this ad account is owned by one.
        /// </summary>
        public Business business { get; set; }
        /// <summary>
        /// City for business address
        /// </summary>
        public string business_city { get; set; }
        /// <summary>
        /// Country code for the business address
        /// </summary>
        public string business_county_code { get; set; }
        /// <summary>
        /// The business name for the account
        /// </summary>
        public string business_name { get; set; }
        /// <summary>
        /// First line of the business street address for the account
        /// </summary>
        public string business_street { get; set; }
        /// <summary>
        /// Second line of the business street address for the account
        /// </summary>
        public string business_street2 { get; set; }
        /// <summary>
        /// Zip code for business address
        /// </summary>
        public string business_zip { get; set; }
        /// <summary>
        /// If we can create a new automated brand lift study under the ad account.
        /// </summary>
        public bool can_create_brand_lift_study { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IList<string> capabilities { get; set; }
        /// <summary>
        /// The time the account was created in ISO 8601 format.
        /// </summary>
        public DateTime created_time { get; set; }
        /// <summary>
        /// The currency used for the account, based on the corresponding value in the account settings. 
        /// </summary>
        public string currency { get; set; }
        public UInt32 disable_reason { get; set; }
        public string end_advertiser { get; set; }
        public string end_advertiser_name { get; set; }
        public IList<DeliveryChecks> failed_DeliveryChecks { get; set; }
        public string funding_source { get; set; }
        //TODO: Find out what this object is
        public object funding_source_details { get; set; }
        public bool has_migrated_permissions { get; set; }
        public string io_number { get; set; }
        public bool is_notifications_enabled { get; set; }
        public UInt32 is_personal { get; set; }
        public bool is_prepay_account { get; set; }
        public bool is_tax_id_required { get; set; }
        public IList<int> line_numbers { get; set; }
        public string media_agency { get; set; }
        public string min_campaign_group_spend_cap { get; set; }
        public UInt32 min_daily_budget { get; set; }
        public string name { get; set; }
        public bool offsite_pixels_tos_accepted { get; set; }
        public string owner { get; set; }
        public string partner { get; set; }
        public ReachAndFrequencySpec rf_spec { get; set; }
        public string salesforce_invoice_group_id { get; set; }
        public bool show_checkout_experience { get; set; }
        public string spend_cap { get; set; }
        public string tax_id { get; set; }
        public UInt32 tax_id_status { get; set; }
        public string tax_id_type { get; set; }
        public UInt32 timezone_id { get; set; }
        public string timezone_name { get; set; }
        public float timezone_offset_hours_utc { get; set; }
        public Tuple<string,int> tos_accepted { get; set; }
        public string user_role { get; set; }
    }
}
