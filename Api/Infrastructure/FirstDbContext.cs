﻿using Api.Core.User;
using System.Data.Entity;

namespace Api.Infrastructure
{
    public interface IFirstDbContext
    {
        IDbSet<User> Users { get; }
        int SaveChanges();
    }

    public class FirstDbContext : DbContext, IFirstDbContext
    {
        public FirstDbContext()
            : base("FirstDbContext")
        {
            //System.Data.Entity.Database.SetInitializer(new DontDropDbJustCreateTablesIfModelChanged<Api.Infrastructure.FirstDbContext>());
        }

        public IDbSet<User> Users { get; set; }
    }
}