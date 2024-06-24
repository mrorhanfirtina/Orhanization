using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Profiles;

public class OrderShipItemsMappingProfiles : Profile
{
    public OrderShipItemsMappingProfiles()
    {

        //CreateOrderShipItemCommand
        CreateMap<CreatedOrderShipItemResponse, OrderShipItem>().ReverseMap();

        //UpdateOrderShipItemCommand
        CreateMap<UpdatedOrderShipItemResponse, OrderShipItem>().ReverseMap();

        //DeleteOrderShipItemCommand
        CreateMap<DeletedOrderShipItemResponse, OrderShipItem>().ReverseMap();

        //GetByIdOrderShipItemQuery
        CreateMap<GetByIdOrderShipItemResponse, OrderShipItem>().ReverseMap();

        //GetListByDynamicOrderShipItemQuery
        CreateMap<GetListByDynamicOrderShipItemListItemDto, OrderShipItem>().ReverseMap();
        CreateMap<Paginate<OrderShipItem>, GetListResponse<GetListByDynamicOrderShipItemListItemDto>>().ReverseMap();

    }
}
