using System;
using System.Collections.Generic;
using System.Text;
using AbpTestLocalization.Localization;
using Volo.Abp.Application.Services;

namespace AbpTestLocalization;

/* Inherit your application services from this class.
 */
public abstract class AbpTestLocalizationAppService : ApplicationService
{
    protected AbpTestLocalizationAppService()
    {
        LocalizationResource = typeof(AbpTestLocalizationResource);
    }
}
