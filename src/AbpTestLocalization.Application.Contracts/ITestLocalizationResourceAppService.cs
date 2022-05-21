using System.Threading.Tasks;

namespace AbpTestLocalization;

public interface ITestLocalizationResourceAppService
{
    Task<string> GetAsync();
    Task<string> GetFromProviderAsync();
}