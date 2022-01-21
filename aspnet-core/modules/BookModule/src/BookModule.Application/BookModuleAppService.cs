using BookModule.Localization;
using Volo.Abp.Application.Services;

namespace BookModule;

public abstract class BookModuleAppService : ApplicationService
{
    protected BookModuleAppService()
    {
        LocalizationResource = typeof(BookModuleResource);
        ObjectMapperContext = typeof(BookModuleApplicationModule);
    }
}
