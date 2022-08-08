using IntegrationAPIOnShow.Configurations;
using IntegrationAPIOnShow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Injectable
{
    public class DbInject
    {
        private readonly AppSettings _appSettings;

        public DbInject(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public IServiceCollection Add(IServiceCollection services)
        {
            services = services.AddDbContext<OnShowContext>(options => options.UseSqlServer(_appSettings.ConnOnShow));

            return services;
        }
    }
}
