using Autofac;
using AutoMapper;
using EClinic.Framework.DependencyInjection;
using System.Reflection;

namespace EClinic.Framework.Mapper
{
    public class MapperDependencyRegistration : DependencyRegistration
    {
        public override void RegisterDependencies(ContainerBuilder builder, params Assembly[] assemblies)
        {
            builder.Register(x =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddMaps(assemblies);
                });

                return config;
            }).AsSelf().SingleInstance();

            builder.Register(x => x.Resolve<MapperConfiguration>().CreateMapper(x.Resolve))
                .AsSelf().As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
