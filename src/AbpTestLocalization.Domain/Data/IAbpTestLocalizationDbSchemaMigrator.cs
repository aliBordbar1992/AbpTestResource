using System.Threading.Tasks;

namespace AbpTestLocalization.Data;

public interface IAbpTestLocalizationDbSchemaMigrator
{
    Task MigrateAsync();
}
