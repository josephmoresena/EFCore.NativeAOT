using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.NativeAOT
{
    public static class SqlServerExtensions
    {
        public static IServiceCollection AddSqlServerContext(this IServiceCollection services, String strConnection)
            => services.AddDbContext<MyDbContext>(options =>
            {
                options.UseSqlServer(strConnection, sqliteOptions =>
                {
                    sqliteOptions.MigrationsAssembly(typeof(SqlServerExtensions).Assembly.FullName);
                });
            });
    }
}