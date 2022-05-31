using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.NativeAOT
{
    public static class SqliteExtensions
    {
        public static IServiceCollection AddSqliteContext(this IServiceCollection services, String strConnection)
            => services.AddDbContext<MyDbContext>(options =>
            {
                options.UseSqlite(strConnection, sqliteOptions =>
                {
                    sqliteOptions.MigrationsAssembly(typeof(SqliteExtensions).Assembly.FullName);
                });
            });
    }
}