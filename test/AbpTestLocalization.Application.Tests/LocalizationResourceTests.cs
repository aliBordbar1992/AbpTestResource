using System.Threading.Tasks;
using AbpTestLocalization.Localization;
using AbpTestLocalization.TextTemplating.Localization;
using Microsoft.Extensions.Localization;
using Shouldly;
using Xunit;

namespace AbpTestLocalization;

public class LocalizationResourceTests : AbpTestLocalizationApplicationTestBase
{
    //this fails
    [Fact]
    public void should_get_text_in_AbpTestLocalizationResource()
    {
        var localizer = GetRequiredService<IStringLocalizer<TemplatesResource>>();


        string text = localizer[TemplatesResource.TestText];

        text.ShouldBeEquivalentTo("A test text in another resource defined in some module");
    }

    //this passes
    [Fact]
    public void should_get_text_in_TemplatesResource()
    {
        var localizer = GetRequiredService<IStringLocalizer<AbpTestLocalizationResource>>();

        string text = localizer[AbpTestLocalizationResource.Test];

        text.ShouldBeEquivalentTo("A test text in default localization resource");
    }

    //this fails
    [Fact]
    public async Task should_render_text_in_template()
    {
        var provider = GetRequiredService<TestTemplateProvider>();

        string expectedText = "Hello Emma! welcome to this test application!";
        //a better way to get the expected text is:
        //var localizer = GetRequiredService<IStringLocalizer<TemplatesResource>>();
        //string expectedText = localizer[TemplatesResource.WelcomeMessage, "Emma"];

        string actualText = await provider.GetRenderedTextAsync();

        actualText.ShouldBeEquivalentTo(expectedText);
    }
}