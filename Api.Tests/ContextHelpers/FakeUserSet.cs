using System.Linq;
using Api.Core.VampireEntities;

namespace Api.Tests.ContextHelpers
{
    public class FakeUserSet : FakeDbSet<User>
    {
        public override User Find(params object[] keyValues)
        {
            return this.SingleOrDefault(u => u.UserId == (int)keyValues.Single());
        }
    }
}