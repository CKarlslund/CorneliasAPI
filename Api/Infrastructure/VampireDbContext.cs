using Api.Core.User;
using System.Data.Entity;

namespace Api.Infrastructure
{
    public interface IVampireDbContext
    {
        IDbSet<User> Users { get; }
        IDbSet<Character> Characters { get; }
        //IDbSet<UserRole> Roles { get; }
        int SaveChanges();
    }

    public class VampireDbContext : DbContext, IVampireDbContext
    {
        public VampireDbContext()
            : base("VampireDbContext")
        {
            //System.Data.Entity.Database.SetInitializer(new DontDropDbJustCreateTablesIfModelChanged<Api.Infrastructure.FirstDbContext>());
        }

        public IDbSet<User> Users { get; set; }
	    public IDbSet<Character> Characters { get; set; }
    }
}