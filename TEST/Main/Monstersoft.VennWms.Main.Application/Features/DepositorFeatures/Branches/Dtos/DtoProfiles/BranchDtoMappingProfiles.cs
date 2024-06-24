using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.DtoProfiles;

public class BranchDtoMappingProfiles : Profile
{
    public BranchDtoMappingProfiles()
    {
        CreateMap<Branch, CreateBranchDto>().ReverseMap();
        CreateMap<Branch, CreateBranchSubDto>().ReverseMap();
        CreateMap<Branch, UpdateBranchDto>().ReverseMap();
        CreateMap<Branch, UpdateBranchSubDto>().ReverseMap();

        CreateMap<Address, BranchAddressResponseDto>().ReverseMap();
        CreateMap<Company, BranchCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BranchDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Distributor, BranchDistributorResponseDto>().ReverseMap();
    }
}
