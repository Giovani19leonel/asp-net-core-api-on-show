using IntegrationAPIOnShow.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Injectable
{
    public class AllInjection
    {
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public AllInjection(IConfiguration configuration)
        {
            _appSettings = new AppSettings(configuration);
            _configuration = configuration;
        }

        public IServiceCollection Add(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSingleton(_configuration);
            services.AddScoped<AppSettings>();

            services = new DbInject(_appSettings).Add(services);
            services = new ServiceInject(_appSettings).Add(services);

            return services;
        }
    }
}
