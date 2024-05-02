using AutoMapper;

namespace KhaPOS_BE.Models;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<ProductAddDto, Product>();
    }
}