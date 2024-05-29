using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.DtoProfiles;

public class OrderDtoMappingProfiles : Profile
{
    public OrderDtoMappingProfiles()
    {
        CreateMap<Order, CreateOrderDto>().ReverseMap();
        CreateMap<Order, CreateOrderSubDto>().ReverseMap();
        CreateMap<Order, UpdateOrderDto>().ReverseMap();
        CreateMap<Order, UpdateOrderSubDto>().ReverseMap();

        CreateMap<Address, OrderAddressResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, OrderAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, OrderCompanyResponseDto>().ReverseMap();
        CreateMap<Customer, OrderCustomerResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, OrderDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, OrderDepositorResponseDto>().ReverseMap();
        CreateMap<OrderAttribute, OrderOrderAttributeResponseDto>().ReverseMap();
        CreateMap<OrderAttributeValue, OrderOrderAttributeValueResponseDto>().ReverseMap();
        CreateMap<OrderItemMemo, OrderOrderItemMemoResponseDto>().ReverseMap();
        CreateMap<OrderItem, OrderOrderItemResponseDto>().ReverseMap();
        CreateMap<OrderItemStockAttrValue, OrderOrderItemStockAttrValueResponseDto>().ReverseMap();
        CreateMap<OrderMemo, OrderOrderMemoResponseDto>().ReverseMap();
        CreateMap<OrderPriority, OrderOrderPriorityResponseDto>().ReverseMap();
        CreateMap<OrderShipItem, OrderOrderShipItemResponseDto>().ReverseMap();
        CreateMap<OrderShipment, OrderOrderShipmentResponseDto>().ReverseMap();
        CreateMap<OrderType, OrderOrderTypeResponseDto>().ReverseMap();
        CreateMap<PriorityList, OrderPriorityListResponseDto>().ReverseMap();
        CreateMap<Product, OrderProductResponseDto>().ReverseMap();
        CreateMap<ProgressStatus, OrderProgressStatusResponseDto>().ReverseMap();
        CreateMap<Receiver, OrderReceiverResponseDto>().ReverseMap();
        CreateMap<Shipment, OrderShipmentResponseDto>().ReverseMap();
        CreateMap<Status, OrderStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, OrderStockAttributeResponseDto>().ReverseMap();
        CreateMap<Unit, OrderUnitResponseDto>().ReverseMap();

    }
}
