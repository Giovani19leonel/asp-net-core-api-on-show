using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Configurations
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;
        public string ConnOnShow { get; set; }

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;

            IConfigurationSection appSettingsSection = _configuration.GetSection("AppSettings");

            ConnOnShow = Environment.GetEnvironmentVariable("ConnOnShow");
            if (string.IsNullOrEmpty(ConnOnShow))
                ConnOnShow = appSettingsSection["ConnOnShow"];
        }
    }
}
