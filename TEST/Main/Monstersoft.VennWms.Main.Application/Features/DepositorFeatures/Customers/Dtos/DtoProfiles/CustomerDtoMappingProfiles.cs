using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoProfiles;

public class CustomerDtoMappingProfiles : Profile
{
    public CustomerDtoMappingProfiles()
    {
        CreateMap<Customer, CreateCustomerDto>().ReverseMap();
        CreateMap<Customer, CreateCustomerSubDto>().ReverseMap();
        CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
        CreateMap<Customer, UpdateCustomerSubDto>().ReverseMap();

        CreateMap<Address, CustomerAddressResponseDto>().ReverseMap();
        CreateMap<Company, CustomerCompanyResponseDto>().ReverseMap();
        CreateMap<Receiver, CustomerReceiverResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, CustomerDepositorCompanyResponseDto>().ReverseMap();
    }
}
