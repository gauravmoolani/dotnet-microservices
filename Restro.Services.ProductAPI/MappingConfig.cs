using AutoMapper;
using Restro.Services.ProductAPI.Models;
using Restro.Services.ProductAPI.Models.Dto;

namespace Restro.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product , ProductDto>();
            });
            return mappingConfig;
        }

    }
}
