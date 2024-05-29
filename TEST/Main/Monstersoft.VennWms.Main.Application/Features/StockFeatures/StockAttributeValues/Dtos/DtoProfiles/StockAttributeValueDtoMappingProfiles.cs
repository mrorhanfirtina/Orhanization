using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.DtoProfiles;

public class StockAttributeValueDtoMappingProfiles : Profile
{
    public StockAttributeValueDtoMappingProfiles()
    {
        CreateMap<StockAttributeValue, CreateStockAttributeValueDto>().ReverseMap();
        CreateMap<StockAttributeValue, CreateStockAttributeValueSubDto>().ReverseMap();
        CreateMap<StockAttributeValue, UpdateStockAttributeValueDto>().ReverseMap();
        CreateMap<StockAttributeValue, UpdateStockAttributeValueSubDto>().ReverseMap();
    }
}
