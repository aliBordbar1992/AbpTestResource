using AbpTestLocalization.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpTestLocalization.Permissions;

public class AbpTestLocalizationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpTestLocalizationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpTestLocalizationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpTestLocalizationResource>(name);
    }
}
