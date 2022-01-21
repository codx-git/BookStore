using Volo.Abp.Modularity;

namespace BookModule;

[DependsOn(
    typeof(BookModuleApplicationModule),
    typeof(BookModuleDomainTestModule)
    )]
public class BookModuleApplicationTestModule : AbpModule
{

}
