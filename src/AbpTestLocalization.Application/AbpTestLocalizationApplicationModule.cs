using AbpTestLocalization.TextTemplating.Localization;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.TextTemplating.Scriban;
using Volo.Abp.VirtualFileSystem;

namespace AbpTestLocalization;

[DependsOn(
    typeof(AbpTestLocalizationDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpTestLocalizationApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpTextTemplatingScribanModule)
    )]
public class AbpTestLocalizationApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpTestLocalizationApplicationModule>();
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpTestLocalizationApplicationModule>("AbpTestLocalization");
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<TemplatesResource>("en")
                .AddVirtualJson("/TextTemplating/Localization/Resources");
        });
    }
}
