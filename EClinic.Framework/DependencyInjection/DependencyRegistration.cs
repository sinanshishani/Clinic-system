using System.Reflection;
using Autofac;

namespace EClinic.Framework.DependencyInjection
{
    public abstract class DependencyRegistration
    {
        public DependencyRegistration() { }
        public abstract void RegisterDependencies(ContainerBuilder builder, params Assembly[] assemblies);
    }
}