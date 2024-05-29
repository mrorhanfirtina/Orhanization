using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoProfiles;

public class OrderMemoDtoMappingProfiles : Profile
{
    public OrderMemoDtoMappingProfiles()
    {
        CreateMap<OrderMemo, CreateOrderMemoDto>().ReverseMap();
        CreateMap<OrderMemo, CreateOrderMemoSubDto>().ReverseMap();
        CreateMap<OrderMemo, UpdateOrderMemoDto>().ReverseMap();
        CreateMap<OrderMemo, UpdateOrderMemoSubDto>().ReverseMap();

        CreateMap<Order, OrderMemoOrderResponseDto>().ReverseMap();
    }
}
