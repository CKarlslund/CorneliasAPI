using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Api.Infrastructure;
using Api.Core.User;
using Api.Tests.ContextHelpers;

namespace Api.Controllers
{
    public class UsersController : ApiController
    {
        public readonly IFirstDbContext context;
        public UsersController()
        {
            //this.context = new FakeFirstDbContext();
            this.context = new FirstDbContext();
        }

        public UsersController(IFirstDbContext context)
        {
            this.context = context;
        }

        // GET api/Users
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var users = context.Users.ToList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message); 
            }
        }

        // GET api/Users/5
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var user = context.Users.ToList().FirstOrDefault(u => u.UserId == id);

            return Request.CreateResponse(HttpStatusCode.OK, user);
        }

        // POST api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Users/5
        public void Delete(int id)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (context is IDisposable)
            {
                ((IDisposable)context).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}