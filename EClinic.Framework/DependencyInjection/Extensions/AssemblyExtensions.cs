using System;
using System.Linq;
using System.Reflection;

namespace EClinic.Framework.DependencyInjection
{
    public static class AssemblyExtensions
    {
        public static Type[] GetExportedTypes<T>(this Assembly assembly)
        {
            return assembly.GetExportedTypes()
                .Where(t => !t.IsAbstract && typeof(T).IsAssignableFrom(t)).ToArray();
        }

        public static Type[] GetExportedServicesTypes(this Assembly assembly)
        {
            return assembly.GetExportedTypes<IDependency>();
        }
    }
}