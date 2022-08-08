using IntegrationAPIOnShow.Configurations;
using IntegrationAPIOnShow.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Injectable
{
    public class ServiceInject
    {
        private readonly AppSettings _appSettings;

        public ServiceInject(AppSettings appSettings)
        {
            appSettings = _appSettings;
        }

        public IServiceCollection Add(IServiceCollection services)
        {
            services = services
                            .AddScoped<MainServices>();

            return services;
        }
    }
}
