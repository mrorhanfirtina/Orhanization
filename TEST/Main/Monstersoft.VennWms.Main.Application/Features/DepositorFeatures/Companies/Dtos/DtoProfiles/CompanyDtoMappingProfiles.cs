using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.DtoProfiles;

public class CompanyDtoMappingProfiles : Profile
{
    public CompanyDtoMappingProfiles()
    {
        CreateMap<Company, CreateCompanyDto>().ReverseMap();
        CreateMap<Company, UpdateCompanyDto>().ReverseMap();

        CreateMap<DepositorCompany, CompanyDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Address, CompanyAddressResponseDto>().ReverseMap();
    }
}
