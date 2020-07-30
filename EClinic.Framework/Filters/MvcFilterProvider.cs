using System.Collections.Generic;
using System.Linq;
using Autofac;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EClinic.Framework.Filters
{
    public class MvcFilterProvider
    {
        private readonly ILifetimeScope _lifetimeScope;

        public MvcFilterProvider(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public IEnumerable<IFilterMetadata> GetFilters()
        {
            return _lifetimeScope.Resolve<IEnumerable<IMvcFilter>>().Select(x => x as IFilterMetadata).Where(x => x != null);
        }
    }
}
