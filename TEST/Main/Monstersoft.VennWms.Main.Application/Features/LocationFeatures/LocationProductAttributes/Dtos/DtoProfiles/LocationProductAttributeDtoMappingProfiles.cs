using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.DtoProfiles;

public class LocationProductAttributeDtoMappingProfiles : Profile
{
    public LocationProductAttributeDtoMappingProfiles()
    {
        CreateMap<LocationProductAttribute, CreateLocationProductAttributeDto>().ReverseMap();
        CreateMap<LocationProductAttribute, CreateLocationProductAttributeSubDto>().ReverseMap();
        CreateMap<LocationProductAttribute, UpdateLocationProductAttributeDto>().ReverseMap();
        CreateMap<LocationProductAttribute, UpdateLocationProductAttributeSubDto>().ReverseMap();

        CreateMap<AttributeInputType, LocationProductAttributeAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Location, LocationProductAttributeLocationResponseDto>().ReverseMap();
        CreateMap<ProductAttribute, LocationProductAttributeProductAttributeResponseDto>().ReverseMap();
    }
}
