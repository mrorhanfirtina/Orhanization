using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.DtoProfiles;

public class SiteDtoMappingProfiles : Profile
{
    public SiteDtoMappingProfiles()
    {
        CreateMap<Site, CreateSiteDto>().ReverseMap();
        CreateMap<Site, UpdateSiteDto>().ReverseMap();

        CreateMap<Building, SiteBuildingResponseDto>().ReverseMap();
        CreateMap<Depositor, SiteDepositorResponseDto>().ReverseMap();
        CreateMap<SiteDepositor, SiteSiteDepositorResponseDto>().ReverseMap();
    }
}
