using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EClinic.Framework.Filters.Options
{
    public class WebApiFilterOptions : IConfigureOptions<MvcOptions>//, IDependency
    {
        private readonly ILifetimeScope _lifetimeScope;

        public WebApiFilterOptions(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public void Configure(MvcOptions options)
        {
            foreach (var filter in new WebApiFilterProvider(_lifetimeScope).GetFilters())
            {
                options.Filters.AddService(filter.GetType());
            }
        }
    }
}