using System.Threading.Tasks;
using Volo.Abp.TextTemplating;

namespace AbpTestLocalization;

public class TestLocalizationResourceAppService : AbpTestLocalizationAppService, ITestLocalizationResourceAppService
{
    private readonly ITemplateRenderer _renderer;
    private readonly TestTemplateProvider _provider;

    public TestLocalizationResourceAppService(ITemplateRenderer renderer, TestTemplateProvider provider)
    {
        _renderer = renderer;
        _provider = provider;
    }

    public async Task<string> GetAsync()
    {
        string text = await _renderer.RenderAsync("TestTemplate", new { name = "Jack" });

        return text;
    }

    public async Task<string> GetFromProviderAsync()
    {
        string text = await _provider.GetRenderedTextAsync();

        return text;
    }
}