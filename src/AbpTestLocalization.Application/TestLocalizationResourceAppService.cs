using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
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

public class TestTemplateProvider : ITransientDependency
{
    private readonly ITemplateRenderer _renderer;

    public TestTemplateProvider(ITemplateRenderer renderer)
    {
        _renderer = renderer;
    }

    public async Task<string> GetRenderedTextAsync()
    {
        string text = await _renderer.RenderAsync("TestTemplate", new { Name = "Emma" });

        return text;
    }
}