using Microsoft.EntityFrameworkCore;

namespace EFCore.NativeAOT
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Table1> Table1 { get; set; } = default!;
    }
}