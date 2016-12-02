using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI.Fields;
using Newtonsoft.Json;

namespace FacebookSharp.GraphAPI.Handlers
{
    /// <summary>
    /// Class for getting a single photo and its data and creation date
    /// </summary>
    public class PhotoHandler : GraphApi
    {
        public string Id { get; set; }

        public PhotoHandler(string id, string token, ApiVersion version) : base(token, version)
        {
            Id = id;
        }

        public PhotoHandler(string id, GraphApi graphApi) : base(graphApi.Token, graphApi.Version)
        {
            Id = id;
        }
        /// <summary>
        /// Get a single photo at an id
        /// </summary>
        /// <returns>Photonode containing ID of photo</returns>
        public async Task<PhotoNode> GetPhoto()
        {
            var json = await GetJson(Id);
            return JsonConvert.DeserializeObject<PhotoNode>(json);
        }
        /// <summary>
        /// Get a single photo at an id
        /// </summary>
        /// <param name="fields">Parameters to get</param>
        /// <returns>PhotoNode containing the ID and all the data obtained from the parameters</returns>
        public async Task<PhotoNode> GetPhoto(ApiField fields)
        {
            var json = await GetJson(Id, fields);
            return JsonConvert.DeserializeObject<PhotoNode>(json);
        }
    }
}
