using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Profiles;

public class OrderShipItemTasksMappingProfiles : Profile
{
    public OrderShipItemTasksMappingProfiles()
    {

        //CreateOrderShipItemTaskCommand
        CreateMap<CreatedOrderShipItemTaskResponse, OrderShipItemTask>().ReverseMap();

        //UpdateOrderShipItemTaskCommand
        CreateMap<UpdatedOrderShipItemTaskResponse, OrderShipItemTask>().ReverseMap();

        //DeleteOrderShipItemTaskCommand
        CreateMap<DeletedOrderShipItemTaskResponse, OrderShipItemTask>().ReverseMap();

        //GetByIdOrderShipItemTaskQuery
        CreateMap<GetByIdOrderShipItemTaskResponse, OrderShipItemTask>().ReverseMap();

        //GetListByDynamicOrderShipItemTaskQuery
        CreateMap<GetListByDynamicOrderShipItemTaskListItemDto, OrderShipItemTask>().ReverseMap();
        CreateMap<Paginate<OrderShipItemTask>, GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>().ReverseMap();

    }
}
