using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;
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
    }
}
