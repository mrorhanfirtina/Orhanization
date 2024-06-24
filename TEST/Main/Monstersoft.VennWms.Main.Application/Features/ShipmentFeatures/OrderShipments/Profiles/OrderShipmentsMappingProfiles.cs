using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Profiles;

public class OrderShipmentsMappingProfiles : Profile
{
    public OrderShipmentsMappingProfiles()
    {

        //CreateOrderShipmentCommand
        CreateMap<CreatedOrderShipmentResponse, OrderShipment>().ReverseMap();

        //UpdateOrderShipmentCommand
        CreateMap<UpdatedOrderShipmentResponse, OrderShipment>().ReverseMap();

        //DeleteOrderShipmentCommand
        CreateMap<DeletedOrderShipmentResponse, OrderShipment>().ReverseMap();

        //GetByCodeOrderShipmentQuery
        CreateMap<GetByCodeOrderShipmentResponse, OrderShipment>().ReverseMap();

        //GetByIdOrderShipmentQuery
        CreateMap<GetByIdOrderShipmentResponse, OrderShipment>().ReverseMap();

        //GetListOrderShipmentQuery
        CreateMap<GetListOrderShipmentListItemDto, OrderShipment>().ReverseMap();
        CreateMap<Paginate<OrderShipment>, GetListResponse<GetListOrderShipmentListItemDto>>().ReverseMap();

        //GetListByDynamicOrderShipmentQuery
        CreateMap<GetListByDynamicOrderShipmentListItemDto, OrderShipment>().ReverseMap();
        CreateMap<Paginate<OrderShipment>, GetListResponse<GetListByDynamicOrderShipmentListItemDto>>().ReverseMap();

    }
}
