using Core.CrossCuttingConcerns.Pipelines.Validation;
using FluentValidation;
using Library.Service.Features.Books.Rules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Service.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();   
            services.AddMediatR(assembly);
            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssembly(assembly);
            services.AddScoped<BookBusinessRules>();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            return services;
        }
    }
}
