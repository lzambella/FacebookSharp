using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookSharp;
using FacebookSharp.GraphAPI.Fields;
using Xunit;

namespace Unit_Tests
{
    public class PageTests
    {
        /// <summary>
        /// Test whether we can load a known user from the API
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task PageTest()
        {
            // Get token from token.txt (ignored by git)
            var token = LoadToken();

            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var page = await graphApi.GetPage("100008443867581");
            var id = page.Id;
            Assert.Equal("100008443867581", id);
        }
        /// <summary>
        /// Test if grabbing from the Photo edge works
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task PhotoTest()
        {
            var token = LoadToken();
            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var page = await graphApi.GetPage("421109484727629");
            var photos = await page.GetPhotos(true);
            Assert.True(photos.PhotoNodes.Any());
        }
        /// <summary>
        /// Attempt to check if using a single field works
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task PhotoTest2()
        {
            var token = LoadToken();
            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var user = await graphApi.GetPage("421109484727629");
            var fields = new ApiField();
            fields.Fields.Add("created_time");
            var photos = await user.GetPhotos(fields, true);
            Assert.NotEmpty(photos.PhotoNodes.First().CreatedTime);
        }
        /// <summary>
        /// Attempt to check if using multiple fields work
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task PhotoTest3()
        {
            var token = LoadToken();
            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var page = await graphApi.GetPage("421109484727629");
            var fields = new ApiField();
            fields.Fields.Add("created_time");
            fields.Fields.Add("from");
            var photos = await page.GetPhotos(fields, true);
            Assert.NotEmpty(photos.PhotoNodes.First().CreatedTime);
            Assert.NotEmpty(photos.PhotoNodes.First().From.Name);
        }
        private string LoadToken()
        {
            return File.ReadAllText("token.txt", Encoding.UTF8);
        }
    }
}