using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EClinic.Framework.Filters.Options
{
    public class MvcFilterOptions : IConfigureOptions<MvcOptions>//, IDependency
    {
        private readonly ILifetimeScope _lifetimeScope;

        public MvcFilterOptions(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public void Configure(MvcOptions options)
        {
            foreach (var filter in new MvcFilterProvider(_lifetimeScope).GetFilters())
            {
                options.Filters.AddService(filter.GetType());
            }
        }
    }
}