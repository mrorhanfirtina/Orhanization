using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoProfiles;

public class StockMemoDtoMappingProfiles : Profile
{
    public StockMemoDtoMappingProfiles()
    {
        CreateMap<StockMemo, CreateStockMemoDto>().ReverseMap();
        CreateMap<StockMemo, CreateStockMemoSubDto>().ReverseMap();
        CreateMap<StockMemo, UpdateStockMemoDto>().ReverseMap();
        CreateMap<StockMemo, UpdateStockMemoSubDto>().ReverseMap();
    }
}
