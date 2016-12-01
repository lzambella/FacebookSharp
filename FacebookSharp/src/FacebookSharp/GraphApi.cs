using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI;
using FacebookSharp.GraphAPI.Fields;
using Newtonsoft.Json;

namespace FacebookSharp
{
    public class GraphApi
    {
        /// <summary>
        /// Determines which api version to use
        /// </summary>
        public enum ApiVersion
        {
            TwoEight,
        }
        /// <summary>
        /// Graph API Token
        /// </summary>
        private string Token { get; set; }
        /// <summary>
        /// API version to use
        /// </summary>
        private ApiVersion Version { get; set; }
        /// <summary>
        /// Create a new GraphApi object that allows
        /// use of the Facebook API
        /// </summary>
        /// <param name="token">Graph API token</param>
        public GraphApi(string token, ApiVersion version)
        {
            Token = token;
            Version = version;
        }
        /// <summary>
        /// Gets the page of a facebook user with a specific ID
        /// </summary>
        /// <param name="id">ID of the user to get from</param>
        /// <returns>Page object containing only the username and id</returns>
        public async Task<Page> GetPage(string id)
        {
            //TODO: Api appears to only return the user name and id, find out how to add all the other parameters defined in the Page documentation
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
        /// <summary>
        /// Gets the string value of the API version contained in Version
        /// </summary>
        /// <returns></returns>
        private string GetVersion()
        {
            switch (Version)
            {
                case ApiVersion.TwoEight:
                    return "v2.8";
            }
            return "";
        }
        /// <summary>
        /// Generate an edge url based on the edge
        /// </summary>
        /// <param name="id">Id of the user</param>
        /// <param name="edge">Edge to get</param>
        /// <returns>URL</returns>
        private string ParseEdge(string id, PageEdge.Edges edge)
        {
            // TODO: finish adding custom URLS
            var s = $"https://graph.facebook.com/{id}/";
            switch (edge)
            {
                case PageEdge.Edges.AdminNotes:
                    s += "admin_notes";
                    break;
                case PageEdge.Edges.Albums:
                    s += "albums";
                    break;
                case PageEdge.Edges.Blocked:
                    s += "blocked";
                    break;
                case PageEdge.Edges.BusinessActivities:
                    s += "business_activities";
                    break;
                case PageEdge.Edges.CallToAction:
                    s += "call_to_action";
                    break;
                case PageEdge.Edges.CanvasElements:
                    s += "canvas_element";
                    break;
                case PageEdge.Edges.ClaimedUrls:
                    s += "claimed_urls";
                    break;
                case PageEdge.Edges.CuratedCollections:
                    s += "curated_collections";
                    break;
                case PageEdge.Edges.Events:
                    s += "events";
                    break;
                case PageEdge.Edges.FeaturedVideosCollection:
                    s += "featured_video_collections";
                    break;
                case PageEdge.Edges.GlobalBrandChildren:
                    s += "global_brand_children";
                    break;
                case PageEdge.Edges.Insights:
                    s += "insights";
                    break;
                case PageEdge.Edges.InstagramAccounts:
                    s += "instagram_accounts";
                    break;
                case PageEdge.Edges.InstantArticles:
                    s += "instant_articles";
                    break;
                case PageEdge.Edges.InstantArticlesInsights:
                    s += "instant_article_insights";
                    break;
                case PageEdge.Edges.Labels:
                    s += "labels";
                    break;
                case PageEdge.Edges.LeadgenContextCards:
                    s += "leadgen_context_cards";
                    break;
                case PageEdge.Edges.LeadgenDraftForms:
                    s += "leadgen_draft_forms";
                    break;
                case PageEdge.Edges.LeadgenForms:
                    s += "leadgen_forms";
                    break;
                case PageEdge.Edges.LeadgenLegalContent:
                    s += "leadgen_legal_content";
                    break;
                case PageEdge.Edges.LeadgenQualifiers:
                    s += "leadgen_qualifiers";
                    break;
                case PageEdge.Edges.LeadgenWhitelistedUsers:
                    s += "leadgen_whitelisted_users";
                    break;
                case PageEdge.Edges.Likes:
                    s += "likes";
                    break;
                case PageEdge.Edges.LiveVideos:
                    s += "live_videos";
                    break;
                case PageEdge.Edges.Locations:
                    s += "locations";
                    break;
                case PageEdge.Edges.MediaFingerprints:
                    s += "media_fingerprints";
                    break;
                case PageEdge.Edges.Milestones:
                    s += "milestones";
                    break;
                case PageEdge.Edges.NativeOffers:
                    s += "native_offers";
                    break;
                case PageEdge.Edges.PageBackedInstagramAccounts:
                    s += "page_backed_instagram_accounts";
                    break;
                case PageEdge.Edges.Photos:
                    s += "photos";
                    break;
                case PageEdge.Edges.Picture:
                    s += "picture";
                    break;
                case PageEdge.Edges.PlaceTopics:
                    break;
                case PageEdge.Edges.ProductCatalogs:
                    break;
                case PageEdge.Edges.Ratings:
                    break;
                case PageEdge.Edges.Roles:
                    break;
                case PageEdge.Edges.SavedFilters:
                    break;
                case PageEdge.Edges.SavedMessageResponses:
                    break;
                case PageEdge.Edges.ScreenNames:
                    break;
                case PageEdge.Edges.Settings:
                    break;
                case PageEdge.Edges.SubscribedApps:
                    break;
                case PageEdge.Edges.Tabs:
                    break;
                case PageEdge.Edges.ThreadSettings:
                    break;
                case PageEdge.Edges.VideoBroadcasts:
                    break;
                case PageEdge.Edges.VideoCopyrightRules:
                    break;
                case PageEdge.Edges.VideoCopyrights:
                    break;
                case PageEdge.Edges.VideoLists:
                    break;
                case PageEdge.Edges.Videos:
                    s += "videos";
                    break;
                case PageEdge.Edges.VideosYouCanUse:
                    break;
                case PageEdge.Edges.Conversations:
                    break;
                case PageEdge.Edges.Feed:
                    break;
                case PageEdge.Edges.Notes:
                    break;
                case PageEdge.Edges.Notifications:
                    break;
                case PageEdge.Edges.Posts:
                    break;
                case PageEdge.Edges.PromotablePosts:
                    break;
                case PageEdge.Edges.Questions:
                    break;
                case PageEdge.Edges.Statuses:
                    s += "statuses";
                    break;
                case PageEdge.Edges.Threads:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(edge), edge, null);
            }
            return s;
        }
    }
}
