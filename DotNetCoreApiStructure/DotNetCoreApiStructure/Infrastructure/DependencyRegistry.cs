using DotNetCoreApiStructure.Common;
using DotNetCoreApiStructure.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStructure.Infrastructure
{
    public static class DependencyRegistry
    {
        public static void RegisterDependency(this IServiceCollection services, AppSettings appsettings)
        {
            services.AddSingleton(appsettings);
            services.AddSingleton(appsettings.ConnectionString);

            //BusinessDependencyRegistry.RegisterDependency(services, appsettings);

            AutoMapperConfig.Bootstrap();
        }
    }
}
