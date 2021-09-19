using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JsonToYaml
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddJsonToYaml(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJsonToYaml, JsonToYaml>();

            return services;
        }
    }
}
