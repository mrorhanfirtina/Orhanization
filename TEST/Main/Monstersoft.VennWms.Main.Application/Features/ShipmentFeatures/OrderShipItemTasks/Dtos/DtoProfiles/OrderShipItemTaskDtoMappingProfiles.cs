using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.DtoProfiles;

public class OrderShipItemTaskDtoMappingProfiles : Profile
{
    public OrderShipItemTaskDtoMappingProfiles()
    {
        CreateMap<OrderShipItemTask, CreateOrderShipItemTaskDto>().ReverseMap();
        CreateMap<OrderShipItemTask, CreateOrderShipItemTaskSubDto>().ReverseMap();
        CreateMap<OrderShipItemTask, UpdateOrderShipItemTaskDto>().ReverseMap();
        CreateMap<OrderShipItemTask, UpdateOrderShipItemTaskSubDto>().ReverseMap();
    }
}
