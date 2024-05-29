using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoProfiles;

public class OrderItemDtoMappingProfiles : Profile
{
    public OrderItemDtoMappingProfiles()
    {
        CreateMap<OrderItem, CreateOrderItemDto>().ReverseMap();
        CreateMap<OrderItem, CreateOrderItemSubDto>().ReverseMap();
        CreateMap<OrderItem, UpdateOrderItemDto>().ReverseMap();
        CreateMap<OrderItem, UpdateOrderItemSubDto>().ReverseMap();

        CreateMap<AttributeInputType, OrderItemAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, OrderItemDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<OrderItemMemo, OrderItemOrderItemMemoResponseDto>().ReverseMap();
        CreateMap<OrderItemStockAttrValue, OrderItemOrderItemStockAttrValueResponseDto>().ReverseMap();
        CreateMap<Order, OrderItemOrderResponseDto>().ReverseMap();
        CreateMap<OrderShipItem, OrderItemOrderShipItemResponseDto>().ReverseMap();
        CreateMap<Product, OrderItemProductResponseDto>().ReverseMap();
        CreateMap<ProgressStatus, OrderItemProgressStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, OrderItemStockAttributeResponseDto>().ReverseMap();
        CreateMap<Unit, OrderItemUnitResponseDto>().ReverseMap();
    }
}
