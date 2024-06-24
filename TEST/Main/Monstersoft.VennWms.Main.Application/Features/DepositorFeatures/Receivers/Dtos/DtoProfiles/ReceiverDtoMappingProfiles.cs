using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.DtoProfiles;

public class ReceiverDtoMappingProfiles : Profile
{
    public ReceiverDtoMappingProfiles()
    {
        CreateMap<Receiver, CreateReceiverDto>().ReverseMap();
        CreateMap<Receiver, UpdateReceiverDto>().ReverseMap();

        CreateMap<Address, ReceiverAddressResponseDto>().ReverseMap();
        CreateMap<Company, ReceiverCompanyResponseDto>().ReverseMap();
        CreateMap<Customer, ReceiverCustomerResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ReceiverDepositorCompanyResponseDto>().ReverseMap();
    }
}
