using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Profiles;

public class OrderShipItemStocksMappingProfiles : Profile
{
    public OrderShipItemStocksMappingProfiles()
    {

        //CreateOrderShipItemStockCommand
        CreateMap<CreatedOrderShipItemStockResponse, OrderShipItemStock>().ReverseMap();

        //UpdateOrderShipItemStockCommand
        CreateMap<UpdatedOrderShipItemStockResponse, OrderShipItemStock>().ReverseMap();

        //DeleteOrderShipItemStockCommand
        CreateMap<DeletedOrderShipItemStockResponse, OrderShipItemStock>().ReverseMap();

        //GetByIdOrderShipItemStockQuery
        CreateMap<GetByIdOrderShipItemStockResponse, OrderShipItemStock>().ReverseMap();

        //GetListByDynamicOrderShipItemStockQuery
        CreateMap<GetListByDynamicOrderShipItemStockListItemDto, OrderShipItemStock>().ReverseMap();
        CreateMap<Paginate<OrderShipItemStock>, GetListResponse<GetListByDynamicOrderShipItemStockListItemDto>>().ReverseMap();

    }
}

