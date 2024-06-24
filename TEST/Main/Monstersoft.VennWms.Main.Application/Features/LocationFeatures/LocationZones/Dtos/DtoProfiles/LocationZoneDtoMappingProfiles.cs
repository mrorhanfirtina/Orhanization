using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoProfiles;

public class LocationZoneDtoMappingProfiles : Profile
{
    public LocationZoneDtoMappingProfiles()
    {
        CreateMap<LocationZone, CreateLocationZoneDto>().ReverseMap();
        CreateMap<LocationZone, CreateLocationZoneSubDto>().ReverseMap();
        CreateMap<LocationZone, UpdateLocationZoneDto>().ReverseMap();
        CreateMap<LocationZone, UpdateLocationZoneSubDto>().ReverseMap();

        CreateMap<Location, LocationZoneLocationResponseDto>().ReverseMap();
        CreateMap<Zone, LocationZoneZoneResponseDto>().ReverseMap();
    }
}
