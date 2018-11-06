using System.Linq;
using Nhom3.EntityFramework;
using Nhom3.MultiTenancy;

namespace Nhom3.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Nhom3DbContext _context;

        public DefaultTenantCreator(Nhom3DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
