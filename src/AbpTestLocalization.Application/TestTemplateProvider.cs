using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.TextTemplating;

namespace AbpTestLocalization;

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