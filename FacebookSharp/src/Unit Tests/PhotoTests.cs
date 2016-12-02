using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookSharp.GraphAPI.Fields;
using FacebookSharp.GraphAPI.Handlers;
using Xunit;
namespace Unit_Tests
{
    public class PhotoTests
    {
        /// <summary>
        /// Test getting a single photo object, checks if the ID field exists since it always gets returned
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task PhotoNodeTests1()
        {
            var token = LoadToken();
            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var photoHandler = new PhotoHandler("634295743409001", graphApi);

            var photo = await photoHandler.GetPhoto();
            Assert.Equal("634295743409001", photo.Id);
        }

        [Fact]
        public async Task PhotoNodeTest2()
        {
            var token = LoadToken();
            var graphApi = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var photoHandler = new PhotoHandler("634295743409001", graphApi);

            var fields = new ApiField();
            fields.Fields.Add("from");
            var photo = await photoHandler.GetPhoto(fields);
            Assert.Equal("ShitpostBot 5000", photo.From.Name);
        }


        private string LoadToken()
        {
            return File.ReadAllText("token.txt", Encoding.UTF8);
        }
    }
}
