using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoProfiles;

public class LocationStockAttributeDtoMappingProfiles : Profile
{
    public LocationStockAttributeDtoMappingProfiles()
    {
        CreateMap<LocationStockAttribute, CreateLocationStockAttributeDto>().ReverseMap();
        CreateMap<LocationStockAttribute, CreateLocationStockAttributeSubDto>().ReverseMap();
        CreateMap<LocationStockAttribute, UpdateLocationStockAttributeDto>().ReverseMap();
        CreateMap<LocationStockAttribute, UpdateLocationStockAttributeSubDto>().ReverseMap();

        CreateMap<AttributeInputType, LocationStockAttributeAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Location, LocationStockAttributeLocationResponseDto>().ReverseMap();
        CreateMap<StockAttribute, LocationStockAttributeStockAttributeResponseDto>().ReverseMap();
    }
}
