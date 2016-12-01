using System.Collections;
using System.Collections.Generic;

namespace FacebookSharp.GraphAPI.Fields
{
    /// <summary>
    /// Different fields for getting data from a Photo object
    /// </summary>
    public class PhotoField
    {
        /*
        public bool Album { get; set; }
        public bool BackdatedTime { get; set; }
        public bool BackdatedTimeGranularity { get; set; }
        public bool CanBackdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanTag { get; set; }
        public bool CreatedTime { get; set; }
        public bool Event { get; set; }
        public bool From { get; set; }
        public bool Height { get; set; }
        public bool Icon { get; set; }
        public bool Images { get; set; }
        public bool Link { get; set; }
        public bool Name { get; set; }
        public bool NameTags { get; set; }
        public bool PageStoryId { get; set; }
        public bool Picture { get; set; }
        public bool Place { get; set; }
        public bool Position { get; set; }
        public bool Target { get; set; }
        public bool Source { get; set; }
        public bool UpdatedTime { get; set; }
        public bool WebpImages { get; set; }
        public bool Width { get; set; }
        */

        public IDictionary<string, bool> Fields { get; set; }
        /// <summary>
        /// Generates url fields corresponding to the data 
        /// </summary>
        /// <returns></returns>
        public string GenerateFields()
        {
            return "";
        }
    }
}
