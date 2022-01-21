using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BookModule.EntityFrameworkCore;

[ConnectionStringName(BookModuleDbProperties.ConnectionStringName)]
public class BookModuleDbContext : AbpDbContext<BookModuleDbContext>, IBookModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public BookModuleDbContext(DbContextOptions<BookModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureBookModule();
    }
}
