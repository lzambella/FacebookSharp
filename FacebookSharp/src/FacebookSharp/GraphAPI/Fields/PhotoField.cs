using System.Collections;
using System.Collections.Generic;

namespace FacebookSharp.GraphAPI.Fields
{
    /// <summary>
    /// Different fields for getting data from a Photo object
    /// </summary>
    public class PhotoField
    {
        /// <summary>
        /// List of fields as defined by https://developers.facebook.com/docs/graph-api/reference/photo
        /// </summary>
        public IList<string> Fields { get; set; }

        public PhotoField()
        {
            Fields = new List<string>();
        }
        /// <summary>
        /// Generates url fields corresponding to the data 
        /// </summary>
        /// <returns></returns>
        public string GenerateFields()
        {
            var s = "fields=";

            for (var i = 0; i < Fields.Count; i++)
            {
                s += Fields[i];
                if (i != Fields.Count - 1)
                    s += ',';
            }
            return s;
        }
    }
}
