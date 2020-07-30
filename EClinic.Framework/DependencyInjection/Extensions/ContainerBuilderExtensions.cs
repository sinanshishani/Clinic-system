using Autofac;
using Autofac.Builder;
using Autofac.Core;
using System;
using System.Linq;
using System.Reflection;

namespace EClinic.Framework.DependencyInjection
{
    public static class ContainerBuilderExtensions
    {
        public static void RegisterDependencies(this ContainerBuilder builder, params Assembly[] assemblies)
        {
            //var excludedTypes = new[] { typeof(ITransientDependency), typeof(IScopedDependency), typeof(ISingletonDependency) };

            //builder.RegisterAssemblyTypes(assemblies)
            //    .PublicOnly()
            //    .AssignableTo<IScopedDependency>()
            //    .Where(type => !type.IsGenericType
            //    .As(x => x.GetInterfacesAndAbstractClasses().Except(excludedTypes))
            //    .AsSelf()
            //    .PropertiesAutowired()
            //    .InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes(assemblies)
            //    .PublicOnly()
            //    .AssignableTo<ISingletonDependency>()
            //    .As(x => x.GetInterfacesAndAbstractClasses().Except(excludedTypes))
            //    .AsSelf()
            //    .PropertiesAutowired()
            //    .SingleInstance();

            //builder.RegisterAssemblyTypes(assemblies)
            //    .PublicOnly()
            //    .AssignableTo<IPerWebRequestDependency>()
            //    .As(x => x.GetInterfacesAndAbstractClasses().Except(excludedTypes))
            //    .AsSelf()
            //    .InstancePerRequest();

            //builder.RegisterAssemblyTypes(assemblies)
            //    .PublicOnly()
            //    .AssignableTo<ITransientDependency>()
            //    .As(x => x.GetInterfacesAndAbstractClasses().Except(excludedTypes))
            //    .AsSelf()
            //    .PropertiesAutowired()
            //    .InstancePerDependency();

            //builder.RegisterAssemblyTypes(assemblies)
            //    .PublicOnly()
            //    .AssignableTo<IScopedDependency>()
            //    .Where(type => type.IsGenericType)
            //    .As(x => x.GetInterfacesAndAbstractClasses().Except(excludedTypes))
            //    .AsSelf()
            //    .PropertiesAutowired()
            //    .RegisterDynamicScope();

            foreach (var serviceType in assemblies.SelectMany(x => x.GetExportedServicesTypes()))
                builder.RegisterDependency(serviceType);

            foreach (var registration in assemblies.SelectMany(assembly => assembly.GetExportedTypes<DependencyRegistration>()))
                Activator.CreateInstance(registration).As<DependencyRegistration>().RegisterDependencies(builder, assemblies);
        }

        public static void RegisterDependency(this ContainerBuilder builder, Type serviceType)
        {
            var excludedTypes = new[] { typeof(IDependency), typeof(ITransientDependency), typeof(ISingletonDependency), typeof(IScopedDependency) };
            var interfaces = serviceType.GetInterfacesAndAbstractClasses().Except(excludedTypes);

            foreach (Type interfaceType in interfaces)
            {
                if (serviceType.IsGenericType)
                    builder.RegisterGeneric(serviceType).As(interfaceType).PropertiesAutowired().RegisterDynamicScope();
                else
                    builder.RegisterType(serviceType).As(interfaceType).PropertiesAutowired().RegisterScope();
            }

            if (serviceType.IsGenericType)
                builder.RegisterGeneric(serviceType).AsSelf().PropertiesAutowired().RegisterDynamicScope();
            else
                builder.RegisterType(serviceType).AsSelf().PropertiesAutowired().RegisterScope();
        }

        private static IRegistrationBuilder<object, ReflectionActivatorData, SingleRegistrationStyle> RegisterScope(
            this IRegistrationBuilder<object, ReflectionActivatorData, SingleRegistrationStyle> registration)
        {
            var type = (registration.RegistrationData.Services.FirstOrDefault() as TypedService).ServiceType;

            if (typeof(ISingletonDependency).IsAssignableFrom(type))
            {
                registration.SingleInstance();
            }
            else if (typeof(ITransientDependency).IsAssignableFrom(type))
            {
                registration.InstancePerDependency();
            }
            else
            {
                registration.InstancePerLifetimeScope();
            }

            return registration;
        }

        private static IRegistrationBuilder<object, ReflectionActivatorData, DynamicRegistrationStyle> RegisterDynamicScope(
            this IRegistrationBuilder<object, ReflectionActivatorData, DynamicRegistrationStyle> registration)
        {
            var type = (registration.RegistrationData.Services.FirstOrDefault() as TypedService).ServiceType;

            if (typeof(ISingletonDependency).IsAssignableFrom(type))
            {
                registration.SingleInstance();
            }
            else if (typeof(ITransientDependency).IsAssignableFrom(type))
            {
                registration.InstancePerDependency();
            }
            else
            {
                registration.InstancePerLifetimeScope();
            }

            return registration;
        }
    }
}