using Microsoft.Extensions.DependencyInjection;

namespace Application.FlowersFarm.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
