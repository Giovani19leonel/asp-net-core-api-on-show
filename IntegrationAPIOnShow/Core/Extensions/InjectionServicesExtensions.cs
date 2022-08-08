﻿using IntegrationAPIOnShow.Injectable;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Core.Extensions
{
    public static class InjectionServicesExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            return new AllInjection(configuration).Add(services);
        }

    }
}
