using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EClinic.Framework.Extensions;

namespace EClinic.Framework.Data
{
    public class AssembliesDbContextEntitiesProvider : IDbContextEntitiesProvider
    {
        private readonly Assembly[] startupAssemblies;

        public AssembliesDbContextEntitiesProvider(Assembly[] startupAssemblies)
        {
            this.startupAssemblies = startupAssemblies;
        }

        public IEnumerable<Type> GetEntities()
        {
            IEnumerable<Type> entities = startupAssemblies.SelectMany(x => x.GetExportedTypes()).Where(e => e.IsClass && !e.IsAbstract && e.IsAssignableToGenericType(typeof(DbEntity<>)));
            return entities;
        }
    }
}
