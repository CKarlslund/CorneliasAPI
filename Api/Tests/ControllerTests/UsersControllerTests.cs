using Api.Controllers;
using Api.Core.User;
using Api.Infrastructure;
using Api.Tests.ContextHelpers;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Xunit;

namespace Api.Tests.ControllerTests
{
    public class UserControllerTests
    {
        [Fact]
        public void DoTheThing()
        {
            var controller = new UsersController(new FakeFirstDbContext())
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            List<User> users;

            var response = controller.Get();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                users = response.Content.ReadAsAsync<List<User>>(new[] { new JsonMediaTypeFormatter() }).Result;
            }
            else
            {
                users = null;
            }

            Assert.NotEmpty(users);
        }

        [Fact]
        public void DoTheThingWithRealDatabase()
        {
            var controller = new UsersController(new FirstDbContext())
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            List<User> users;

            var response = controller.Get();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                users = response.Content.ReadAsAsync<List<User>>(new[] { new JsonMediaTypeFormatter() }).Result;
            }
            else
            {
                users = null;
            }

            Assert.NotEmpty(users);
        }
    }
}