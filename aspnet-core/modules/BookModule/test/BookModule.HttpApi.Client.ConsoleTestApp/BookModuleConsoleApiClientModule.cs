using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace BookModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BookModuleConsoleApiClientModule : AbpModule
{

}
