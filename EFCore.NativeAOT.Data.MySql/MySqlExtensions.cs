using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.NativeAOT
{
    public static class MySqlExtensions
    {
        public static IServiceCollection AddMySqlContext(this IServiceCollection services, String strConnection)
            => services.AddDbContext<MyDbContext>(options =>
            {
                options.UseMySql(strConnection, ServerVersion.AutoDetect(strConnection), sqliteOptions =>
                {
                    sqliteOptions.MigrationsAssembly(typeof(MySqlExtensions).Assembly.FullName);
                });
            });
    }
}