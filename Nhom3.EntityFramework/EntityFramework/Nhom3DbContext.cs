using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Nhom3.Authorization.Roles;
using Nhom3.Authorization.Users;
using Nhom3.MultiTenancy;
using Nhom3.Models;
using System.Data.Entity;


namespace Nhom3.EntityFramework
{
    public class Nhom3DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public Nhom3DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in Nhom3DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of Nhom3DbContext since ABP automatically handles it.
         */
        public Nhom3DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public Nhom3DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public Nhom3DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
