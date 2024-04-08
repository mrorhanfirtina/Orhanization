using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Profiles;

public class OrderItemsMappingProfiles : Profile
{
    public OrderItemsMappingProfiles()
    {

        //CreateOrderItemCommand
        CreateMap<CreatedOrderItemResponse, OrderItem>().ReverseMap();

        //UpdateOrderItemCommand
        CreateMap<UpdatedOrderItemResponse, OrderItem>().ReverseMap();

        //DeleteOrderItemCommand
        CreateMap<DeletedOrderItemResponse, OrderItem>().ReverseMap();

        //GetByIdOrderItemQuery
        CreateMap<GetByIdOrderItemResponse, OrderItem>().ReverseMap();

        //GetListByDynamicOrderItemQuery
        CreateMap<GetListByDynamicOrderItemListItemDto, OrderItem>().ReverseMap();
        CreateMap<Paginate<OrderItem>, GetListResponse<GetListByDynamicOrderItemListItemDto>>().ReverseMap();

    }
}
