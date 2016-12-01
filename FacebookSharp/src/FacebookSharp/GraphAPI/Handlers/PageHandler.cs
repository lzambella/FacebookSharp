using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookSharp.GraphAPI.Handlers
{
    public class PageHandler
    {
        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns>Page object containing only the username and id</returns>
        public async Task<Page> GetPage(string id)
        {
            var http = $"https://graph.facebook.com/{GetVersion()}/{id}?access_token={Token}";
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
        /// Gets an edge of a Page (ie. photos and videos)
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns></returns>
        public async Task<Photo> GetPhotos(string id)
        {
            var v = GetVersion();
            var url = $"https://graph.facebook.com/{v}/{id}/photos?access_token={Token}";
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

        public async Task<Photo> GetPhotos(string id, PhotoField fields)
        {
            var v = GetVersion();
            var url = $"https://graph.facebook.com/{v}/{id}/photos?access_token={Token}{fields.GenerateFields()}";
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
    }
}
