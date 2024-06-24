using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.DtoProfiles;

public class DistributorDtoMappingProfiles : Profile
{
    public DistributorDtoMappingProfiles()
    {
        CreateMap<Distributor, CreateDistributorDto>().ReverseMap();
        CreateMap<Distributor, CreateDistributorSubDto>().ReverseMap();
        CreateMap<Distributor, UpdateDistributorDto>().ReverseMap();
        CreateMap<Distributor, UpdateDistributorSubDto>().ReverseMap();

        CreateMap<Address, DistributorAddressResponseDto>().ReverseMap();
        CreateMap<Company, DistributorCompanyResponseDto>().ReverseMap();
        CreateMap<Branch, DistributorBranchResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, DistributorDepositorCompanyResponseDto>().ReverseMap();
    }
}
