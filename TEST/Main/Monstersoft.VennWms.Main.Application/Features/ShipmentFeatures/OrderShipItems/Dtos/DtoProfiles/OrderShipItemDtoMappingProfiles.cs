using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;
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
    }
}
