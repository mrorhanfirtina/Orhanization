using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.DtoProfiles;

public class LocationPickingTypeDtoMappingProfiles : Profile
{
    public LocationPickingTypeDtoMappingProfiles()
    {
        CreateMap<LocationPickingType, CreateLocationPickingTypeDto>().ReverseMap();
        CreateMap<LocationPickingType, CreateLocationPickingTypeSubDto>().ReverseMap();
        CreateMap<LocationPickingType, UpdateLocationPickingTypeDto>().ReverseMap();
        CreateMap<LocationPickingType, UpdateLocationPickingTypeSubDto>().ReverseMap();

        CreateMap<Location, LocationPickingTypeLocationResponseDto>().ReverseMap();
        CreateMap<PickingType, LocationPickingTypePickingTypeResponseDto>().ReverseMap();
    }
}
