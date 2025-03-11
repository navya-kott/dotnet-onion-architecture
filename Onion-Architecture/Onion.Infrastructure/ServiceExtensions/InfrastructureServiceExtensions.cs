using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion.Core.Interfaces;

namespace Onion.Infrastructure.ServiceExtensions
{
   public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IRepository, BlogRepository>();
            return services;
        }
    }
}
