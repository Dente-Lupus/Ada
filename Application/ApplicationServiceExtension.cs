using Microsoft.Extensions.DependencyInjection;
using System;
using Application.Queries;

namespace Application
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IHomeQuery, HomeQuery>();
            return services;
        }
    }
}
