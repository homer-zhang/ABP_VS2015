using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Template.Dev.EntityFramework;

namespace Template.Dev.Migrator
{
    [DependsOn(typeof(DevDataModule))]
    public class DevMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DevDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}