using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Profiles;

public class OrderItemMemosMappingProfiles : Profile
{
    public OrderItemMemosMappingProfiles()
    {

        //CreateOrderItemMemoCommand
        CreateMap<CreatedOrderItemMemoResponse, OrderItemMemo>().ReverseMap();

        //UpdateOrderItemMemoCommand
        CreateMap<UpdatedOrderItemMemoResponse, OrderItemMemo>().ReverseMap();

        //DeleteOrderItemMemoCommand
        CreateMap<DeletedOrderItemMemoResponse, OrderItemMemo>().ReverseMap();

        //GetByIdOrderItemMemoQuery
        CreateMap<GetByIdOrderItemMemoResponse, OrderItemMemo>().ReverseMap();

        //GetListByDynamicOrderItemMemoQuery
        CreateMap<GetListByDynamicOrderItemMemoListItemDto, OrderItemMemo>().ReverseMap();
        CreateMap<Paginate<OrderItemMemo>, GetListResponse<GetListByDynamicOrderItemMemoListItemDto>>().ReverseMap();

    }
}

