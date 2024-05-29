using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.DtoProfiles;

public class AddressDtoMappingProfiles : Profile
{
    public AddressDtoMappingProfiles()
    {
        CreateMap<Address, CreateAddressDto>().ReverseMap();
        CreateMap<Address, CreateAddressSubDto>().ReverseMap();
        CreateMap<Address, UpdateAddressDto>().ReverseMap();
        CreateMap<Address, UpdateAddressSubDto>().ReverseMap();
    }
}
