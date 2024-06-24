using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.DtoProfiles;

public class DepositorDtoMappingProfiles : Profile
{
    public DepositorDtoMappingProfiles()
    {
        CreateMap<Depositor, CreateDepositorDto>().ReverseMap();
        CreateMap<Depositor, CreateDepositorSubDto>().ReverseMap();
        CreateMap<Depositor, UpdateDepositorDto>().ReverseMap();
        CreateMap<Depositor, UpdateDepositorSubDto>().ReverseMap();

        CreateMap<Address, DepositorAddressResponseDto>().ReverseMap();
        CreateMap<Company, DepositorCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, DepositorDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorFeature, DepositorDepositorFeatureResponseDto>().ReverseMap();
    }
}
