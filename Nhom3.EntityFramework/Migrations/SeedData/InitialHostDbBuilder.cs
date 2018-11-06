using Nhom3.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Nhom3.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly Nhom3DbContext _context;

        public InitialHostDbBuilder(Nhom3DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
