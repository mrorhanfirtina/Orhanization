using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.DtoProfiles;

public class OrderShipmentDtoMappingProfiles : Profile
{
    public OrderShipmentDtoMappingProfiles()
    {
        CreateMap<OrderShipment, CreateOrderShipmentDto>().ReverseMap();
        CreateMap<OrderShipment, CreateOrderShipmentSubDto>().ReverseMap();
        CreateMap<OrderShipment, UpdateOrderShipmentDto>().ReverseMap();
        CreateMap<OrderShipment, UpdateOrderShipmentSubDto>().ReverseMap();

        CreateMap<DepositorCompany, OrderShipmentsDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<ItemUnit, OrderShipmentsItemUnitResponseDto>().ReverseMap();
        CreateMap<OrderItem, OrderShipmentsOrderItemResponseDto>().ReverseMap();
        CreateMap<Order, OrderShipmentsOrderResponseDto>().ReverseMap();
        CreateMap<OrderShipItem, OrderShipmentsOrderShipItemResponseDto>().ReverseMap();
        CreateMap<OrderShipItemStock, OrderShipmentsOrderShipItemStockResponseDto>().ReverseMap();
        CreateMap<OrderShipItemTask, OrderShipmentsOrderShipItemTaskResponseDto>().ReverseMap();
        CreateMap<Product, OrderShipmentsProductResponseDto>().ReverseMap();
        CreateMap<ProgressStatus, OrderShipmentsProgressStatusResponseDto>().ReverseMap();
        CreateMap<Shipment, OrderShipmentsShipmentResponseDto>().ReverseMap();
        CreateMap<Unit, OrderShipmentsUnitResponseDto>().ReverseMap();
    }
}
