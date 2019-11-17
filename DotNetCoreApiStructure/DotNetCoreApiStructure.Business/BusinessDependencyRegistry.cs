using DotNetCoreApiStructure.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreApiStructure.Business
{
    public class BusinessDependencyRegistry
    {
        public static void RegisterDependency(IServiceCollection services, AppSettings appSettings)
        {
            //RepositoryDependencyRegistry.RegisterDependency(services, appSettings);

            //services.AddTransient<IBusinessOrderShopKeepers, BusinessOrdersShopKeepers>();
        }
    }
}
