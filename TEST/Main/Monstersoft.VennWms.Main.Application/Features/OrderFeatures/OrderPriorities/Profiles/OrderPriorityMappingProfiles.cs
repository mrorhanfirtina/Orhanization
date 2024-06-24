using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Profiles;

public class OrderPriorityMappingProfiles : Profile
{
    public OrderPriorityMappingProfiles()
    {
        //CreateOrderPriorityCommand
        CreateMap<CreatedOrderPriorityResponse, OrderPriority>().ReverseMap();

        //UpdateOrderPriorityCommand
        CreateMap<UpdatedOrderPriorityResponse, OrderPriority>().ReverseMap();

        //DeleteOrderPriorityCommand
        CreateMap<DeletedOrderPriorityResponse, OrderPriority>().ReverseMap();

        //GetByIdOrderPriorityQuery
        CreateMap<GetByIdOrderPriorityResponse, OrderPriority>().ReverseMap();

        //GetListByDynamicOrderPriorityQuery
        CreateMap<OrderPriority, GetListByDynamicOrderPriorityListItemDto>().ReverseMap();
        CreateMap<Paginate<OrderPriority>, GetListResponse<GetListByDynamicOrderPriorityListItemDto>>().ReverseMap();

    }
}


