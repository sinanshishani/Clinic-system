using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

namespace EClinic.Framework.Logging
{
    public class SerilogLogger
    {
        public static ILogger Initialize()
        {
            /*
             * Dependencies:
             * - Serilog.AspNetCore
             */

            var configuration = new ConfigurationBuilder()
                                   .SetBasePath(Directory.GetCurrentDirectory())
                                   .AddJsonFile("appsettings.LogConfigs.json")
                                   .Build();

            Log.Logger = new LoggerConfiguration()
               .ReadFrom.Configuration(configuration)
               .CreateLogger();

            return Log.Logger;
        }
    }
}