using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.DtoProfiles;

public class StockDtoMappingProfiles : Profile
{
    public StockDtoMappingProfiles()
    {
        CreateMap<Stock, CreateStockDto>().ReverseMap();
        CreateMap<Stock, UpdateStockDto>().ReverseMap();
    }
}
