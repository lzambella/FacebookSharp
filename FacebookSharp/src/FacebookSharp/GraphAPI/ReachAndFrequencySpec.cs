using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    public class ReachAndFrequencySpec
    {
        public IList<string> countries { get; set; }
        public string min_campaign_duration { get; set; }
        public string max_campaign_duration { get; set; }
        public string max_days_to_finish { get; set; }
        public string min_reach_limit { get; set; }
    }
}
