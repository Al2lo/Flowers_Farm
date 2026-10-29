using Microsoft.Extensions.DependencyInjection;

namespace Domain.FlowersFarm.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
