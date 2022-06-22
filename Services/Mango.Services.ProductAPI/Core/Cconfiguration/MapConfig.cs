using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Core.Cconfiguration
{
    public class MapConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mapConfig = new MapperConfiguration(c =>
              {
                  c.CreateMap<ProductDto, Product>().ReverseMap();
              });

            return mapConfig;
        }
    }
}
