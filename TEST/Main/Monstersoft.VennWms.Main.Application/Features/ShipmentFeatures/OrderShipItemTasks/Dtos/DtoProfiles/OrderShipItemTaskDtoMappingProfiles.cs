using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.DtoProfiles;

public class OrderShipItemTaskDtoMappingProfiles : Profile
{
    public OrderShipItemTaskDtoMappingProfiles()
    {
        CreateMap<OrderShipItemTask, CreateOrderShipItemTaskDto>().ReverseMap();
        CreateMap<OrderShipItemTask, CreateOrderShipItemTaskSubDto>().ReverseMap();
        CreateMap<OrderShipItemTask, UpdateOrderShipItemTaskDto>().ReverseMap();
        CreateMap<OrderShipItemTask, UpdateOrderShipItemTaskSubDto>().ReverseMap();

        CreateMap<OrderShipItem, OrderShipItemTasksOrderShipItemResponseDto>().ReverseMap();
        CreateMap<OrderShipItemStock, OrderShipItemTasksOrderShipItemStockResponseDto>().ReverseMap();
        CreateMap<StockPackType, OrderShipItemTasksStockPackTypeResponseDto>().ReverseMap();
        CreateMap<Stock, OrderShipItemTasksStockResponseDto>().ReverseMap();
        CreateMap<WorkTask, OrderShipItemTasksWorkTaskResponseDto>().ReverseMap();
    }
}
