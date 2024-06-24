using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.DtoProfiles;

public class DepositorCompanyDtoMappingProfiles : Profile
{
    public DepositorCompanyDtoMappingProfiles()
    {
        CreateMap<DepositorCompany, CreateDepositorCompanyDto>().ReverseMap();
        CreateMap<DepositorCompany, UpdateDepositorCompanyDto>().ReverseMap();

        CreateMap<Address, DepositorCompanyAddressResponseDto>().ReverseMap();
    }
}

