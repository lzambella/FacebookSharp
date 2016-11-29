using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI
{
    public class AdRecommendation
    {
        //TODO: not the best name
        public enum Importance
        {
            HIGH, MEDIUM, LOW
        }
        public string blame_field { get; set; }
        public int code { get; set; }
        public Importance confidence { get; set; }
        public Importance importance { get; set; }
        public string message { get; set; }
        public object recommendation_data { get; set; }
        public string title { get; set; }
    }
}
