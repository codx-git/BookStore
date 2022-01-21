using BookModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookModule;

public abstract class BookModuleController : AbpControllerBase
{
    protected BookModuleController()
    {
        LocalizationResource = typeof(BookModuleResource);
    }
}
