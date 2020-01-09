using System.Data.Entity;
using Api.Core.VampireEntities;

namespace Api.Infrastructure
{
	public interface IVampireDbContext
	{
		IDbSet<User> Users { get; }
		IDbSet<Character> Characters { get; }
		int SaveChanges();
	}
}