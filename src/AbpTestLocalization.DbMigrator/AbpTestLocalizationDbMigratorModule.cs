using AbpTestLocalization.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpTestLocalization.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpTestLocalizationEntityFrameworkCoreModule),
    typeof(AbpTestLocalizationApplicationContractsModule)
    )]
public class AbpTestLocalizationDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
