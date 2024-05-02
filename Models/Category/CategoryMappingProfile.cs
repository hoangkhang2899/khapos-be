using AutoMapper;

namespace KhaPOS_BE.Models;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<CategoryAddDto, Category>();
    }
}