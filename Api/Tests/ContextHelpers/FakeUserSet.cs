using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Api.Models;

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