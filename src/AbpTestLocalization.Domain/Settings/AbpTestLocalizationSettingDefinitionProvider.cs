using Volo.Abp.Settings;

namespace AbpTestLocalization.Settings;

public class AbpTestLocalizationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpTestLocalizationSettings.MySetting1));
    }
}
