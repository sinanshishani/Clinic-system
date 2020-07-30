using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace EClinic.Framework.Configurations
{
    public sealed class AppConfigs
    {
        private IConfiguration _configuration;
        private static readonly object padlock = new object();

        public AppConfigs(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static AppConfigs Instance { get; private set; }
        public string this[string key] { get => _configuration[key]; set => _configuration[key] = value; }

        public string Secret
        {
            get {
                string secret = _configuration["Auth0:Secret"];
                if(string.IsNullOrEmpty(secret))
                    return "yeOiPcesRcoE1TAFy0Hehs64yOhWpOwvN3v7UvtJ7QEgpu4j7f5lvVqoeODa1lpaLdkrD3kjiTwQCkQUeyNBww==";
                
                return secret;
            }
        }

        public static AppConfigs CreateInstance(IConfiguration configuration)
        {
            if (Instance == null)
            {
                lock (padlock)
                {
                    if (Instance == null)
                        Instance = new AppConfigs(configuration);
                }
            }

            return Instance;
        }

        public string GetConnectionString(string connectionStringName)
        {
            string connectionString = _configuration.GetConnectionString(connectionStringName);
            return connectionString;
        }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            return _configuration.GetChildren();
        }

        public IConfigurationSection GetSection(string key)
        {
            return _configuration.GetSection(key);
        }

        public IChangeToken GetReloadToken()
        {
            throw new System.NotImplementedException();
        }
    }
}
