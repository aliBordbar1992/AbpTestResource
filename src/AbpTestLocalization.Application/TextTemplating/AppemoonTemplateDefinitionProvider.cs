using System;
using AbpTestLocalization.TextTemplating.Localization;
using Volo.Abp.TextTemplating;
using Volo.Abp.TextTemplating.Scriban;

namespace AbpTestLocalization.TextTemplating;

public class AppemoonTemplateDefinitionProvider : TemplateDefinitionProvider
{
    public override void Define(ITemplateDefinitionContext context)
    {
        var t = new TemplateDefinition($"TestTemplate", typeof(TemplatesResource))
            .WithVirtualFilePath($"/TextTemplating/Templates/TestTemplate.tpl", true)
            .WithScribanEngine();

        context.Add(t);
    }
}