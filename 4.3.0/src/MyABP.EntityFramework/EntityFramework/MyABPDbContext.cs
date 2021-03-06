﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MyABP.Authorization.Roles;
using MyABP.Authorization.Users;
using MyABP.MultiTenancy;
using MyABP.Tasks;

namespace MyABP.EntityFramework
{
    public class MyABPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyABPDbContext since ABP automatically handles it.
         */
        public MyABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyABPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyABPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Task> Tasks { get; set; }
    }
}
