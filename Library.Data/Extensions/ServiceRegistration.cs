using Library.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Data.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("LibraryDbConn"));
            });

            return services;
        }
    }
}
