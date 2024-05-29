using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.DtoProfiles;

public class OrderItemMemoDtoMappingProfiles : Profile
{
    public OrderItemMemoDtoMappingProfiles()
    {
        CreateMap<OrderItemMemo, CreateOrderItemMemoDto>().ReverseMap();
        CreateMap<OrderItemMemo, CreateOrderItemMemoSubDto>().ReverseMap();
        CreateMap<OrderItemMemo, UpdateOrderItemMemoDto>().ReverseMap();
        CreateMap<OrderItemMemo, UpdateOrderItemMemoSubDto>().ReverseMap();

        CreateMap<OrderItem, OrderItemMemoOrderItemResponseDto>().ReverseMap();
        CreateMap<Order, OrderItemMemoOrderResponseDto>().ReverseMap();
        CreateMap<Product, OrderItemMemoProductResponseDto>().ReverseMap();
    }
}
