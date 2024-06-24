using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Profiles;

public class OrderItemStockAttrValuesMappingProfiles : Profile
{
    public OrderItemStockAttrValuesMappingProfiles()
    {

        //CreateOrderItemStockAttrValueCommand
        CreateMap<CreatedOrderItemStockAttrValueResponse, OrderItemStockAttrValue>().ReverseMap();

        //UpdateOrderItemStockAttrValueCommand
        CreateMap<UpdatedOrderItemStockAttrValueResponse, OrderItemStockAttrValue>().ReverseMap();

        //DeleteOrderItemStockAttrValueCommand
        CreateMap<DeletedOrderItemStockAttrValueResponse, OrderItemStockAttrValue>().ReverseMap();

        //GetByIdOrderItemStockAttrValueQuery
        CreateMap<GetByIdOrderItemStockAttrValueResponse, OrderItemStockAttrValue>().ReverseMap();

        //GetListByDynamicOrderItemStockAttrValueQuery
        CreateMap<GetListByDynamicOrderItemStockAttrValueListItemDto, OrderItemStockAttrValue>().ReverseMap();
        CreateMap<Paginate<OrderItemStockAttrValue>, GetListResponse<GetListByDynamicOrderItemStockAttrValueListItemDto>>().ReverseMap();

    }
}
