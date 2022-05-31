using System.Reflection;

using Microsoft.OpenApi.Models;

namespace EFCore.NativeAOT
{
    public class Startup
    {
        private static readonly String assemblyName = Assembly.GetExecutingAssembly().GetName().Name!;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // This workaround is necessary for initializing SQLite drivers in NativeAOT
            SQLitePCL.Batteries_V2.Init();

            services
                .AddSqlServerContext(Configuration.GetConnectionString("SqlServer"))
            //.AddMySqlContext(Configuration.GetConnectionString("MySql"))
            //.AddPostgreSqlContext(Configuration.GetConnectionString("PostgreSql"))
            //.AddSqliteContext(Configuration.GetConnectionString("Sqlite"))
            ;

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = assemblyName, Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{assemblyName} v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
