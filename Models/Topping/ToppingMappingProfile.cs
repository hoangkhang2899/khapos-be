using AutoMapper;

namespace KhaPOS_BE.Models;

public class ToppingMappingProfile : Profile
{
    public ToppingMappingProfile()
    {
        CreateMap<ToppingAddDto, Topping>();
    }
}