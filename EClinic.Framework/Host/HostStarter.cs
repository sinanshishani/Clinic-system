using Autofac;
using AutofacSerilogIntegration;
using EClinic.Framework.Configurations;
using EClinic.Framework.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace EClinic.Framework.Host
{
    public static class HostStarter
    {
        public static void InitializeHost(ContainerBuilder builder)
        {
            Assembly[] assemblies = Assemblies.Get();

            builder.RegisterInstance(assemblies).Named<Assembly[]>("_startupAssemblies").AsSelf().SingleInstance();

            builder.RegisterDependencies(assemblies);
            builder.RegisterAssemblyModules(assemblies);

            builder.RegisterLogger(autowireProperties: true);
        }

        public static void InitializeConfigurations(IConfiguration configuration)
        {
            AppConfigs.CreateInstance(configuration);
        }
    }
}