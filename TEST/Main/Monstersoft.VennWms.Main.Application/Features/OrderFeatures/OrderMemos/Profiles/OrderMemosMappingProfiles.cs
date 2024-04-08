using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Profiles;

public class OrderMemosMappingProfiles : Profile
{
    public OrderMemosMappingProfiles()
    {

        //CreateOrderMemoCommand
        CreateMap<CreatedOrderMemoResponse, OrderMemo>().ReverseMap();

        //UpdateOrderMemoCommand
        CreateMap<UpdatedOrderMemoResponse, OrderMemo>().ReverseMap();

        //DeleteOrderMemoCommand
        CreateMap<DeletedOrderMemoResponse, OrderMemo>().ReverseMap();

        //GetByIdOrderMemoQuery
        CreateMap<GetByIdOrderMemoResponse, OrderMemo>().ReverseMap();

        //GetListByDynamicOrderMemoQuery
        CreateMap<GetListByDynamicOrderMemoListItemDto, OrderMemo>().ReverseMap();
        CreateMap<Paginate<OrderMemo>, GetListResponse<GetListByDynamicOrderMemoListItemDto>>().ReverseMap();

    }
}

