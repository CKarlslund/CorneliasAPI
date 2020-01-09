using System.Data.Entity;
using Api.Core.VampireEntities;

namespace Api.Infrastructure
{
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