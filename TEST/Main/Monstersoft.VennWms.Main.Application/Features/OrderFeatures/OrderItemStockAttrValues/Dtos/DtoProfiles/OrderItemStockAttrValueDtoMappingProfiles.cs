using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.DtoProfiles;

public class OrderItemStockAttrValueDtoMappingProfiles : Profile
{
    public OrderItemStockAttrValueDtoMappingProfiles()
    {
        CreateMap<OrderItemStockAttrValue, CreateOrderItemStockAttrValueDto>().ReverseMap();
        CreateMap<OrderItemStockAttrValue, CreateOrderItemStockAttrValueSubDto>().ReverseMap();
        CreateMap<OrderItemStockAttrValue, UpdateOrderItemStockAttrValueDto>().ReverseMap();
        CreateMap<OrderItemStockAttrValue, UpdateOrderItemStockAttrValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, OrderItemStockAttrValueAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemStockAttrValueOrderItemResponseDto>().ReverseMap();
        CreateMap<Order, OrderItemStockAttrValueOrderResponseDto>().ReverseMap();
        CreateMap<Product, OrderItemStockAttrValueProductResponseDto>().ReverseMap();
        CreateMap<StockAttribute, OrderItemStockAttrValueStockAttributeResponseDto>().ReverseMap();
    }
}
