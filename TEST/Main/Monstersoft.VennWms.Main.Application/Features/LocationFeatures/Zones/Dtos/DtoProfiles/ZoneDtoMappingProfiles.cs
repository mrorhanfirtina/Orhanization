using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.DtoProfiles;

public class ZoneDtoMappingProfiles : Profile
{
    public ZoneDtoMappingProfiles()
    {
        CreateMap<Zone, CreateZoneDto>().ReverseMap();
        CreateMap<Zone, UpdateZoneDto>().ReverseMap();

        CreateMap<Building, ZoneBuildingResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ZoneDepositorCompanyResponseDto>().ReverseMap();
    }
}
