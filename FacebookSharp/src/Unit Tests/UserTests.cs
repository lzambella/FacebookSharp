using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookSharp;
using FacebookSharp.GraphAPI;
using FacebookSharp.GraphAPI.ApiParameters;
using Xunit;
namespace Unit_Tests
{
    public class UserTests
    {
        /// <summary>
        /// Test getting a single user by ID, no fields should default to name and id
        /// </summary>
        [Fact]
        public async void UserTest()
        {
            var token = GetToken();
            var api = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var user = await api.GetUser("4");
            Assert.Equal("Mark Zuckerberg", user.Name);
        }
        /// <summary>
        /// Tests getting a user with a single field
        /// </summary>
        [Fact]
        public async void UserSingleFieldTest()
        {
            var token = GetToken();
            var api = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var userFields = new UserField();
            userFields.Fields.Add(UserField.UserFields.LastName);
            var user = await api.GetUser("4", userFields);
            Assert.Equal("Zuckerberg", user.LastName);
        }
        /// <summary>
        /// Tests getting more than one field
        /// </summary>
        [Fact]
        public async void UserMultipleFieldsTest()
        {
            var token = GetToken();
            var api = new GraphApi(token, GraphApi.ApiVersion.TwoEight);
            var userFields = new UserField();
            userFields.Fields.Add(UserField.UserFields.LastName);
            userFields.Fields.Add(UserField.UserFields.FirstName);
            var user = await api.GetUser("4", userFields);
            Assert.Equal("Mark", user.FirstName);
            Assert.Equal("Zuckerberg", user.LastName);
        }
        private string GetToken()
        {
            return File.ReadAllText("token.txt", Encoding.UTF8);
        }
    }
}
