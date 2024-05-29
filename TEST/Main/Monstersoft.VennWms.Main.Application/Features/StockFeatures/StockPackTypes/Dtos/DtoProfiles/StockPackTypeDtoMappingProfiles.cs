using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.DtoProfiles;

public class StockPackTypeDtoMappingProfiles : Profile
{
    public StockPackTypeDtoMappingProfiles()
    {
        CreateMap<StockPackType, CreateStockPackTypeDto>().ReverseMap();
        CreateMap<StockPackType, CreateStockPackTypeSubDto>().ReverseMap();
        CreateMap<StockPackType, UpdateStockPackTypeDto>().ReverseMap();
        CreateMap<StockPackType, UpdateStockPackTypeSubDto>().ReverseMap();
    }
}
