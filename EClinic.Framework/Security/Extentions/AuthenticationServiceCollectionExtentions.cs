using Microsoft.Extensions.DependencyInjection;

namespace EClinic.Framework.Security
{
    public static class AuthenticationServiceCollectionExtentions
    {
        public static void AddAuthConfigs(this IServiceCollection services)
        {
            services.AddAuthentication().AddJwtBearer();
            services.ConfigureOptions<WebApiAuthOptions>();
            services.ConfigureOptions<WebApiJwtBearerOptions>();
        }
    }
}
