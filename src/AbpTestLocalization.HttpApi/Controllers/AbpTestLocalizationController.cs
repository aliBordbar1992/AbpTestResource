using AbpTestLocalization.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpTestLocalization.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpTestLocalizationController : AbpControllerBase
{
    protected AbpTestLocalizationController()
    {
        LocalizationResource = typeof(AbpTestLocalizationResource);
    }
}
