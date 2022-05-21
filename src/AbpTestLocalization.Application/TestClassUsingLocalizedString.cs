using AbpTestLocalization.TextTemplating.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp.DependencyInjection;

namespace AbpTestLocalization;

public class TestClassUsingLocalizedString : ITransientDependency
{
    private readonly IStringLocalizer<TemplatesResource> _localizer;

    public TestClassUsingLocalizedString(IStringLocalizer<TemplatesResource> localizer)
    {
        _localizer = localizer;
    }

    public string GetText()
    {
        string text = _localizer[TemplatesResource.TestText];

        return text;
    }
}