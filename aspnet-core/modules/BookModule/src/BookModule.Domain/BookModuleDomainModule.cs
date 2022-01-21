using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace BookModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(BookModuleDomainSharedModule)
)]
public class BookModuleDomainModule : AbpModule
{

}
