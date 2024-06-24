using AutoMapper;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoProfiles;

public class OrderPriorityDtoMappingProfiles : Profile
{
    public OrderPriorityDtoMappingProfiles()
    {
        CreateMap<OrderPriority, CreateOrderPriorityDto>().ReverseMap();
        CreateMap<OrderPriority, CreateOrderPrioritySubDto>().ReverseMap();
        CreateMap<OrderPriority, UpdateOrderPriorityDto>().ReverseMap();
        CreateMap<OrderPriority, UpdateOrderPrioritySubDto>().ReverseMap();

        CreateMap<Order, OrderPriorityOrderResponseDto>().ReverseMap();
        CreateMap<PriorityList, OrderPriorityPriorityListResponseDto>().ReverseMap();
    }
}
