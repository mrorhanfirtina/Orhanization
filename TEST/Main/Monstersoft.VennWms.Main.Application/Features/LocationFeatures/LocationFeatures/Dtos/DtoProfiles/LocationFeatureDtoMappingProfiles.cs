using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.DtoProfiles;

public class LocationFeatureDtoMappingProfiles : Profile
{
    public LocationFeatureDtoMappingProfiles()
    {
        CreateMap<LocationFeature, CreateLocationFeatureDto>().ReverseMap();
        CreateMap<LocationFeature, CreateLocationFeatureSubDto>().ReverseMap();
        CreateMap<LocationFeature, UpdateLocationFeatureDto>().ReverseMap();
        CreateMap<LocationFeature, UpdateLocationFeatureSubDto>().ReverseMap();

        CreateMap<Location, LocationFeatureLocationResponseDto>().ReverseMap();
    }
}
