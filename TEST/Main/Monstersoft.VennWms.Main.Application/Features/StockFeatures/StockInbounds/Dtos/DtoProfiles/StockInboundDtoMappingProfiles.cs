using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
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

        CreateMap<ItemUnit, StockInboundsItemUnitResponseDto>().ReverseMap();
        CreateMap<Receipt, StockInboundsReceiptResponseDto>().ReverseMap();
        CreateMap<Return, StockInboundsReturnResponseDto>().ReverseMap();
        CreateMap<Stock, StockInboundsStockResponseDto>().ReverseMap();
        CreateMap<Unit, StockInboundsUnitResponseDto>().ReverseMap();
    }
}
