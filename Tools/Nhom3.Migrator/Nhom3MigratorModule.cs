using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Nhom3.EntityFramework;

namespace Nhom3.Migrator
{
    [DependsOn(typeof(Nhom3DataModule))]
    public class Nhom3MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<Nhom3DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}