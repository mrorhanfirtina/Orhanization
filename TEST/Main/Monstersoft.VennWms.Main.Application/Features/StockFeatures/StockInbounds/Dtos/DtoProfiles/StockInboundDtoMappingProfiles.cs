using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.DtoProfiles;

public class StockInboundDtoMappingProfiles : Profile
{
    public StockInboundDtoMappingProfiles()
    {
        CreateMap<StockInbound, CreateStockInboundDto>().ReverseMap();
        CreateMap<StockInbound, CreateStockInboundSubDto>().ReverseMap();
        CreateMap<StockInbound, UpdateStockInboundDto>().ReverseMap();
        CreateMap<StockInbound, UpdateStockInboundSubDto>().ReverseMap();
    }
}
