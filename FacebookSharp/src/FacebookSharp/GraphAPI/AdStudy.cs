using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    public class AdStudy
    {
        public Business business { get; set; }
        public string canceled_time { get; set; }
        public User created_by { get; set; }
        public string created_ttime { get; set; }
        public string description { get; set; }
        public string end_time { get; set; }
        public string id { get; set; }
        public string cooldown_start_time { get; set; }
        public string type { get; set; }
        public User updated_by { get; set; }
        public string update_time { get; set; } 
    }
}
