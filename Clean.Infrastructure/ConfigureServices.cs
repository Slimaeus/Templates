using Clean.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region DbContext
            services.AddDbContext<DbContext, ApplicationDbContext>(options =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                if (env == "Development")
                {
                    options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
                }
                else
                {
                    options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
                }
            });

            services.AddScoped<ApplicationDbContextInitializer>();
            #endregion

            //#region UnitOfWork
            //services.AddUnitOfWork();
            //services.AddUnitOfWork<ApplicationDbContext>();
            //#endregion
            return services;
        }
    }
}
