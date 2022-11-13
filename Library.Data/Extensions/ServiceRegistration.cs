using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Data.Repositories.Concretes;
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
            services.AddScoped<IAdressRepository,AdressRepository>();
            services.AddScoped<IAuthorRepository,AuthorRepository>();   
            services.AddScoped<IBookPublisherRepository,BookPublisherRepository>();
            services.AddScoped<IBookRepository,BookRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IPublisherRepository,PublisherRepository>();

            return services;
        }
    }
}
