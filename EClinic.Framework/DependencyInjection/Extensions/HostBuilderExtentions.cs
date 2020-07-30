using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EClinic.Framework.DependencyInjection
{
    public static class IHostBuilderExtentions
    {
        public static IHostBuilder UseAutofacServiceProviderFactory(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        }
    }
}