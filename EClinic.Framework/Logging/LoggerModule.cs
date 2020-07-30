using Autofac;

namespace EClinic.Framework.Logging
{
    public class LoggerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register((c, p) =>
            //{
            //    return SerilogLogger.Initialize();
            //}).SingleInstance();
        }
    }
}
