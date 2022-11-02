using AventHub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AventHub.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AventHubEntityFrameworkCoreModule),
    typeof(AventHubApplicationContractsModule)
    )]
public class AventHubDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
