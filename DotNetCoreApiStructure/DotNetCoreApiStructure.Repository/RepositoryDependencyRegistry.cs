using DotNetCoreApiStructure.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreApiStructure.Repository
{
    public class RepositoryDependencyRegistry
    {
        public static void RegisterDependency(IServiceCollection services, AppSettings appSettings)
        {
            //services.AddDbContext<UDMeShopContext>(x => x.UseSqlServer(appSettings.ConnectionString));

            //services.AddTransient<IRepositoryOrders, RepositoryOrders>();
        }
    }
}
