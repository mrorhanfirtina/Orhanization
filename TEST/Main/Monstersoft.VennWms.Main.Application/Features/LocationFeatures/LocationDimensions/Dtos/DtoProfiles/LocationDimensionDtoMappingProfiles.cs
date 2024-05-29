using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.DtoProfiles;

public class LocationDimensionDtoMappingProfiles : Profile
{
    public LocationDimensionDtoMappingProfiles()
    {
        CreateMap<LocationDimension, CreateLocationDimensionDto>().ReverseMap();
        CreateMap<LocationDimension, CreateLocationDimensionSubDto>().ReverseMap();
        CreateMap<LocationDimension, UpdateLocationDimensionDto>().ReverseMap();
        CreateMap<LocationDimension, UpdateLocationDimensionSubDto>().ReverseMap();

        CreateMap<Unit, LocationDimensionLengthUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationDimensionVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationDimensionWeightUnitResponseDto>().ReverseMap();
        CreateMap<Location, LocationDimensionLocationResponseDto>().ReverseMap();
    }
}
