using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyABP.EntityFramework;

namespace MyABP.Migrator
{
    [DependsOn(typeof(MyABPDataModule))]
    public class MyABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}