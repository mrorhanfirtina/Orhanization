using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.DtoProfiles;

public class SiteDepositorDtoMappingProfiles : Profile
{
    public SiteDepositorDtoMappingProfiles()
    {
        CreateMap<SiteDepositor, CreateSiteDepositorDto>().ReverseMap();
        CreateMap<SiteDepositor, CreateSiteDepositorSubDto>().ReverseMap();
        CreateMap<SiteDepositor, UpdateSiteDepositorDto>().ReverseMap();
        CreateMap<SiteDepositor, UpdateSiteDepositorSubDto>().ReverseMap();

        CreateMap<Site, SiteDepositorSiteResponseDto>().ReverseMap();
        CreateMap<Depositor, SiteDepositorDepositorResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, SiteDepositorCompanyResponseDto>().ReverseMap();
    }
}
