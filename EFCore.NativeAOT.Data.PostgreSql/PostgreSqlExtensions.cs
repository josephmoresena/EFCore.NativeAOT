using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.NativeAOT
{
    public static class PostgreSqlExtensions
    {
        public static IServiceCollection AddPostgreSqlContext(this IServiceCollection services, String strConnection)
            => services.AddDbContext<MyDbContext>(options =>
            {
                options.UseNpgsql(strConnection, sqliteOptions =>
                {
                    sqliteOptions.MigrationsAssembly(typeof(PostgreSqlExtensions).Assembly.FullName);
                });
            });
    }
}