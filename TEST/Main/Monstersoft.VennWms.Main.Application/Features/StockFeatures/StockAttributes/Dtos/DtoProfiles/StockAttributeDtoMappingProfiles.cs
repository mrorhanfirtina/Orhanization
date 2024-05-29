using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.DtoProfiles;

public class StockAttributeDtoMappingProfiles : Profile
{
    public StockAttributeDtoMappingProfiles()
    {
        CreateMap<StockAttribute, CreateStockAttributeDto>().ReverseMap();
        CreateMap<StockAttribute, UpdateStockAttributeDto>().ReverseMap();
    }
}
