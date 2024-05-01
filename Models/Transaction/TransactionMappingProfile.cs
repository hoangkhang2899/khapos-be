using AutoMapper;

namespace KhaPOS_BE.Models;

public class TransactionMappingProfile : Profile
{
    public TransactionMappingProfile()
    {
        CreateMap<TransactionAddDto, Transaction>();
    }
}