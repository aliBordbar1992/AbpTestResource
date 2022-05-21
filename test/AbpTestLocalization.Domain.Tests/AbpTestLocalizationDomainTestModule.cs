using AbpTestLocalization.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpTestLocalization;

[DependsOn(
    typeof(AbpTestLocalizationEntityFrameworkCoreTestModule)
    )]
public class AbpTestLocalizationDomainTestModule : AbpModule
{

}
