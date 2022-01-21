using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BookModule.EntityFrameworkCore;

[ConnectionStringName(BookModuleDbProperties.ConnectionStringName)]
public interface IBookModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
