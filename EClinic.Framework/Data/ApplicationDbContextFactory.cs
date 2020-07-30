using EClinic.Framework.Host;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EClinic.Framework.Data
{
    public abstract class ApplicationDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : ApplicationDbContext
    {
        public TContext CreateDbContext(string[] args)
        {
            var assemblies = new Assembly[] { Assembly.GetAssembly(typeof(HostStarter)) }.Concat(GetAssemblies()).Distinct().ToArray();
            var types = assemblies.SelectMany(x => x.GetExportedTypes());
            var providers = types
                .Where(e => e.IsClass && !e.IsAbstract && typeof(IDbContextEntitiesProvider).IsAssignableFrom(e))
                .Select(x => Activator.CreateInstance(x, new object[] { assemblies }).As<IDbContextEntitiesProvider>());

            return Activator.CreateInstance(typeof(TContext), providers).As<TContext>();
        }

        public abstract Assembly[] GetAssemblies();
    }
}
