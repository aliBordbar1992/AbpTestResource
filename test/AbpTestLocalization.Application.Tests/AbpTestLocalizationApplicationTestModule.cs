using Volo.Abp.Modularity;

namespace AbpTestLocalization;

[DependsOn(
    typeof(AbpTestLocalizationApplicationModule),
    typeof(AbpTestLocalizationDomainTestModule)
    )]
public class AbpTestLocalizationApplicationTestModule : AbpModule
{

}
