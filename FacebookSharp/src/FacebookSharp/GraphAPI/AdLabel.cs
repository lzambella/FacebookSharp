using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    /// <summary>
    /// An AdLabel
    /// </summary>
    public class AdLabel
    {
        /// <summary>
        /// Ad label ID
        /// </summary>
        string id { get; set; }
        public AdAccount account { get; set; }
        public string created_time { get; set; }
        public string name { get; set; }
        public string updated_time { get; set; }
    }
}
