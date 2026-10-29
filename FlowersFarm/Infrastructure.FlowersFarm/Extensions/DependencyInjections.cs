using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.FlowersFarm.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}