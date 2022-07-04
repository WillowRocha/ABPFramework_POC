using ABP.GettingStarted.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABP.GettingStarted.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GettingStartedEntityFrameworkCoreModule),
    typeof(GettingStartedApplicationContractsModule)
    )]
public class GettingStartedDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
