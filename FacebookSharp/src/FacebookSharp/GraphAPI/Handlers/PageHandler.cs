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
    /// Gets data from Page object and its edges
    /// </summary>
    public class PageHandler : GraphApi
    {
        /// <summary>
        /// Id of the page to get.
        /// </summary>
        public string PageId { get; set; }

        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns>Page object containing only the username and id</returns>
        public async Task<Page> GetPage()
        {
            var http = $"https://graph.facebook.com/{GetVersion()}/{PageId}?access_token={Token}";
            var request = WebRequest.Create(http);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<Page>(json);
                return data;
            }
        }
        /// <summary>
        /// Gets the Photo edge of a page
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns>Photo object containing list of IDs and Names</returns>
        public async Task<Photo> GetPhotos()
        {
            var v = GetVersion();
            var url = $"https://graph.facebook.com/{v}/{PageId}/photos?access_token={Token}";
            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<Photo>(json);
                return data;
            }
        }
        /// <summary>
        /// Gets Photo edge of a Page containing data pertaining to fields input
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Fields of data to be returned</param>
        /// <returns></returns>
        public async Task<Photo> GetPhotos(ApiField fields)
        {
            var v = GetVersion();
            var url = $"https://graph.facebook.com/{v}/{PageId}/photos?access_token={Token}&{fields.GenerateFields()}";
            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)await request.GetResponseAsync();
            if (response == null)
                return null;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var json = await sr.ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<Photo>(json);
                return data;
            }
        }
        /// <summary>
        /// Create a new PageHandler object
        /// </summary>
        /// <param name="token">Graph API token</param>
        /// <param name="version">Graph API version</param>
        /// <param name="id">ID of page to get from</param>
        public PageHandler(string token, ApiVersion version, string id) : base(token, version)
        {
            PageId = id;
        }
        /// <summary>
        /// Create a new PageHandler object
        /// </summary>
        /// <param name="graphApi">GraphApi object containing token and version to use</param>
        /// <param name="id">ID of page to get from</param>
        public PageHandler(GraphApi graphApi, string id) : base(graphApi.Token, graphApi.Version)
        {
            PageId = id;
        }


    }
}
