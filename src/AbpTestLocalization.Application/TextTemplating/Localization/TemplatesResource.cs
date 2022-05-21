using Volo.Abp.Localization;

namespace AbpTestLocalization.TextTemplating.Localization;

[LocalizationResourceName("Templates")]
public class TemplatesResource
{
    public const string TestText = nameof(TestText);
    public const string WelcomeMessage = nameof(WelcomeMessage);
}