using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    /// <summary>
    /// Delivery checks are a set of tests which can help find out potential issues related to ad delivery.
    /// </summary>
    public class DeliveryChecks
    {
        public string check_name { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
    }
}
