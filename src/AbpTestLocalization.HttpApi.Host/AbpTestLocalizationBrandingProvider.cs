using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpTestLocalization;

[Dependency(ReplaceServices = true)]
public class AbpTestLocalizationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpTestLocalization";
}
