using BookModule.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BookModule;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(BookModuleEntityFrameworkCoreTestModule)
    )]
public class BookModuleDomainTestModule : AbpModule
{

}
