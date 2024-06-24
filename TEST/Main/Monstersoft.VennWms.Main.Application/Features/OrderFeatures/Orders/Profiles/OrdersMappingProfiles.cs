using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Profiles;

public class OrdersMappingProfiles : Profile
{
    public OrdersMappingProfiles()
    {

        //CreateOrderCommand
        CreateMap<CreatedOrderResponse, Order>().ReverseMap();

        //UpdateOrderCommand
        CreateMap<UpdatedOrderResponse, Order>().ReverseMap();

        //DeleteOrderCommand
        CreateMap<DeletedOrderResponse, Order>().ReverseMap();

        //GetByCodeOrderQuery
        CreateMap<GetByCodeOrderResponse, Order>().ReverseMap();

        //GetByIdOrderQuery
        CreateMap<GetByIdOrderResponse, Order>().ReverseMap();

        //GetListOrderQuery
        CreateMap<GetListOrderListItemDto, Order>().ReverseMap();
        CreateMap<Paginate<Order>, GetListResponse<GetListOrderListItemDto>>().ReverseMap();

        //GetListByDynamicOrderQuery
        CreateMap<GetListByDynamicOrderListItemDto, Order>().ReverseMap();
        CreateMap<Paginate<Order>, GetListResponse<GetListByDynamicOrderListItemDto>>().ReverseMap();

    }
}
