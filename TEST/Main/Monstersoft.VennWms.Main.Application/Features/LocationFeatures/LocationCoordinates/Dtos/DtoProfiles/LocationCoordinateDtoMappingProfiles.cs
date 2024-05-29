using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.DtoProfiles;

public class LocationCoordinateDtoMappingProfiles : Profile
{
    public LocationCoordinateDtoMappingProfiles()
    {
        CreateMap<LocationCoordinate, CreateLocationCoordinateDto>().ReverseMap();
        CreateMap<LocationCoordinate, CreateLocationCoordinateSubDto>().ReverseMap();
        CreateMap<LocationCoordinate, UpdateLocationCoordinateDto>().ReverseMap();
        CreateMap<LocationCoordinate, UpdateLocationCoordinateSubDto>().ReverseMap();

        CreateMap<BuildingDimension, LocationCoordinateBuildingDimensionResponseDto>().ReverseMap();
        CreateMap<Building, LocationCoordinateBuildingResponseDto>().ReverseMap();
        CreateMap<Unit, LocationCoordinateLenghtUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationCoordinateVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Location, LocationCoordinateLocationResponseDto>().ReverseMap();
    }
}
