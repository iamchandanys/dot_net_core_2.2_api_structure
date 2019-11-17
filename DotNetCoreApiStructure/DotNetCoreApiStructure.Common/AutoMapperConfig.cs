using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreApiStructure.Common
{
    public class AutoMapperConfig
    {
        public static void Bootstrap()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<OrderItems, OrderItemsDto>();
                //cfg.CreateMap<OrderItemsDto, OrderItems>();
            });
        }
    }
}
