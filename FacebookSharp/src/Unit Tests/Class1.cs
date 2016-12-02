using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacebookSharp;
using Xunit;
using FacebookSharp.GraphAPI;
using System.IO;
using System.Text;
using FacebookSharp.GraphAPI.Fields;
using FacebookSharp.GraphAPI.Handlers;

namespace UnitTests
{
    public class UnitTests
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
            var pageHandler = new PageHandler(graphApi, "100008443867581");
            var page = await pageHandler.GetPage();
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
            var pageHandler = new PageHandler(graphApi, "421109484727629");
            var photos = await pageHandler.GetPhotos();
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
            var photoHandler = new PageHandler(graphApi, "421109484727629");
            var fields = new PhotoField();
            fields.Fields.Add("created_time");
            var photos = await photoHandler.GetPhotos(fields);
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
            var photoHandler = new PageHandler(graphApi, "421109484727629");
            var fields = new PhotoField();
            fields.Fields.Add("created_time");
            fields.Fields.Add("from");
            var photos = await photoHandler.GetPhotos(fields);
            Assert.NotEmpty(photos.PhotoNodes.First().CreatedTime);
            Assert.NotEmpty(photos.PhotoNodes.First().From.Name);
        }
        private string LoadToken()
        {
            return File.ReadAllText("token.txt", Encoding.UTF8);
        }
    }
}