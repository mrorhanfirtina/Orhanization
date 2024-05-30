using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.DtoProfiles;

public class OrderShipItemStockDtoMappingProfiles : Profile
{
    public OrderShipItemStockDtoMappingProfiles()
    {
        CreateMap<OrderShipItemStock, CreateOrderShipItemStockDto>().ReverseMap();
        CreateMap<OrderShipItemStock, CreateOrderShipItemStockSubDto>().ReverseMap();
        CreateMap<OrderShipItemStock, UpdateOrderShipItemStockDto>().ReverseMap();
        CreateMap<OrderShipItemStock, UpdateOrderShipItemStockSubDto>().ReverseMap();

        CreateMap<OrderShipItem, OrderShipItemStocksOrderShipItemResponseDto>().ReverseMap();
        CreateMap<OrderShipItemTask, OrderShipItemStocksOrderShipItemTaskResponseDto>().ReverseMap();
        CreateMap<StockPackType, OrderShipItemStocksStockPackTypeResponseDto>().ReverseMap();
        CreateMap<Stock, OrderShipItemStocksStockResponseDto>().ReverseMap();
    }
}
