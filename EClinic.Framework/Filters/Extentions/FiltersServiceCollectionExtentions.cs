using EClinic.Framework.Filters.Options;
using Microsoft.Extensions.DependencyInjection;

namespace EClinic.Framework.Filters.Extentions
{
    public static class FiltersServiceCollectionExtentions
    {
        public static void AddMvcFilterServices(this IServiceCollection services)
        {
            services.ConfigureOptions<MvcFilterOptions>();
        }

        public static void AddWebApiFilterServices(this IServiceCollection services)
        {
            services.ConfigureOptions<WebApiFilterOptions>();
        }
    }
}
