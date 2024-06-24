using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.DtoProfiles;

public class OrderShipItemDtoMappingProfiles : Profile
{
    public OrderShipItemDtoMappingProfiles()
    {
        CreateMap<OrderShipItem, CreateOrderShipItemDto>().ReverseMap();
        CreateMap<OrderShipItem, CreateOrderShipItemSubDto>().ReverseMap();
        CreateMap<OrderShipItem, UpdateOrderShipItemDto>().ReverseMap();
        CreateMap<OrderShipItem, UpdateOrderShipItemSubDto>().ReverseMap();

        CreateMap<ItemUnit, OrderShipItemsItemUnitResponseDto>().ReverseMap();
        CreateMap<OrderItem, OrderShipItemsOrderItemResponseDto>().ReverseMap();
        CreateMap<OrderShipItemStock, OrderShipItemsOrderShipItemStockResponseDto>().ReverseMap();
        CreateMap<OrderShipItemTask, OrderShipItemsOrderShipItemTaskResponseDto>().ReverseMap();
        CreateMap<OrderShipment, OrderShipItemsOrderShipmentResponseDto>().ReverseMap();
        CreateMap<Product, OrderShipItemsProductResponseDto>().ReverseMap();
        CreateMap<ProgressStatus, OrderShipItemsProgressStatusResponseDto>().ReverseMap();
        CreateMap<Shipment, OrderShipItemsShipmentResponseDto>().ReverseMap();
        CreateMap<Unit, OrderShipItemsUnitResponseDto>().ReverseMap();
    }
}
