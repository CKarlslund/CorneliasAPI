using Api.Core.User;
using Api.Infrastructure;
using System.Data.Entity;

namespace Api.Tests.ContextHelpers
{
    public class FakeFirstDbContext : IFirstDbContext
    {
        public FakeFirstDbContext()
        {
            this.Users = GetFakeUsers();
        }

        public IDbSet<User> Users { get; private set; }
        public int SaveChanges()
        {
            return 0;
        }

        private IDbSet<User> GetFakeUsers()
        {
            var fakeUsers = new FakeDbSet<User>
            {
                new User
                {
                    UserId = 1,
                    Name = "Cornelia Karlslund",
                    Password = "abc123"
                },

                new User
                {
                    UserId = 2,
                    Name = "Martin Euframsson",
                    Password = "111222"
                },

                new User
                {
                    UserId = 3,
                    Name = "Johanna Nilsson",
                    Password = "abc13333"
                }
            };

            return fakeUsers;
        }
    }
}