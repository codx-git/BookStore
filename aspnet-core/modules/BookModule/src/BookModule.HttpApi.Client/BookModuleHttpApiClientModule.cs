using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BookModule;

[DependsOn(
    typeof(BookModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class BookModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BookModuleApplicationContractsModule).Assembly,
            BookModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BookModuleHttpApiClientModule>();
        });

    }
}
