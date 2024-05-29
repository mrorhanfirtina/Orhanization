using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoProfiles;

public class LocationProductAbcCategoryDtoMappingProfiles : Profile
{
    public LocationProductAbcCategoryDtoMappingProfiles()
    {
        CreateMap<LocationProductAbcCategory, CreateLocationProductAbcCategoryDto>().ReverseMap();
        CreateMap<LocationProductAbcCategory, CreateLocationProductAbcCategorySubDto>().ReverseMap();
        CreateMap<LocationProductAbcCategory, UpdateLocationProductAbcCategoryDto>().ReverseMap();
        CreateMap<LocationProductAbcCategory, UpdateLocationProductAbcCategorySubDto>().ReverseMap();

        CreateMap<AbcCategoryList, LocationProductAbcCategoryAbcCategoryResponseDto>().ReverseMap();
        CreateMap<Location, LocationProductAbcCategoryLocationResponseDto>().ReverseMap();
    }
}
