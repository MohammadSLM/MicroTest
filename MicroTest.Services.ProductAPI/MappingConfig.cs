using AutoMapper;
using MicroTest.Services.ProductAPI.Models;
using MicroTest.Services.ProductAPI.Models.Dto;

namespace MicroTest.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
