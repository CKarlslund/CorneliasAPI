using Api.Infrastructure;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IVampireDbContext context;
        public UsersController()
        {
            //this.context = new FakeFirstDbContext();
            this.context = new VampireDbContext();
        }

        public UsersController(IVampireDbContext context)
        {
            this.context = context;
        }

        // GET api/Users
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var users = context.Users.Include(u => u.Characters).ToList();

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