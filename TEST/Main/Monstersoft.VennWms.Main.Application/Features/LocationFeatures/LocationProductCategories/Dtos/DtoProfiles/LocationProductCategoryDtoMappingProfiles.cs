using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoProfiles;

public class LocationProductCategoryDtoMappingProfiles : Profile
{
    public LocationProductCategoryDtoMappingProfiles()
    {
        CreateMap<LocationProductCategory, CreateLocationProductCategoryDto>().ReverseMap();
        CreateMap<LocationProductCategory, CreateLocationProductCategorySubDto>().ReverseMap();
        CreateMap<LocationProductCategory, UpdateLocationProductCategoryDto>().ReverseMap();
        CreateMap<LocationProductCategory, UpdateLocationProductCategorySubDto>().ReverseMap();

        CreateMap<Location, LocationProductCategoryLocationResponseDto>().ReverseMap();
        CreateMap<ProductCategoryList, LocationProductCategoryCategoryResponseDto>().ReverseMap();
    }
}
