using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpTestLocalization.Data;

/* This is used if database provider does't define
 * IAbpTestLocalizationDbSchemaMigrator implementation.
 */
public class NullAbpTestLocalizationDbSchemaMigrator : IAbpTestLocalizationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
