using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacebookSharp;
using Xunit;
using FacebookSharp.GraphAPI;
using System.IO;
using System.Text;

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
            var page = await graphApi.GetPage("100008443867581");
            var id = page.id;
            Console.WriteLine(id);
            Assert.Equal("100008443867581", id);
        }


        private string LoadToken()
        {
            return File.ReadAllText("token.txt", Encoding.UTF8);
        }
    }
}