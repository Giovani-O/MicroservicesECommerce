using AutoMapper;
using MicroservicesECommerce.ProductApi.Models;

namespace MicroservicesECommerce.ProductApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();  
    }
}
