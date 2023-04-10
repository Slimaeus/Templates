using Clean.API.Filters;
using Clean.Infrastructure.Persistence;

namespace Clean.API
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services)
        {
            services.AddHealthChecks().AddDbContextCheck<ApplicationDbContext>();

            #region Controllers
            services.AddControllers(options =>
            {
                options.Filters.Add<ApiExceptionFilterAttribute>();
            });
            #endregion

            #region Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            #endregion

            return services;
        }
    }
}
