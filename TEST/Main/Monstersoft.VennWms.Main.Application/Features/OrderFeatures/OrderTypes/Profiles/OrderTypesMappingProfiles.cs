using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Profiles;

public class OrderTypesMappingProfiles : Profile
{
    public OrderTypesMappingProfiles()
    {

        //CreateOrderTypeCommand
        CreateMap<CreatedOrderTypeResponse, OrderType>().ReverseMap();

        //UpdateOrderTypeCommand
        CreateMap<UpdatedOrderTypeResponse, OrderType>().ReverseMap();

        //DeleteOrderTypeCommand
        CreateMap<DeletedOrderTypeResponse, OrderType>().ReverseMap();

        //GetByCodeOrderTypeQuery
        CreateMap<GetByCodeOrderTypeResponse, OrderType>().ReverseMap();

        //GetByIdOrderTypeQuery
        CreateMap<GetByIdOrderTypeResponse, OrderType>().ReverseMap();

        //GetListOrderTypeQuery
        CreateMap<GetListOrderTypeListItemDto, OrderType>().ReverseMap();
        CreateMap<Paginate<OrderType>, GetListResponse<GetListOrderTypeListItemDto>>().ReverseMap();

        //GetListByDynamicOrderTypeQuery
        CreateMap<GetListByDynamicOrderTypeListItemDto, OrderType>().ReverseMap();
        CreateMap<Paginate<OrderType>, GetListResponse<GetListByDynamicOrderTypeListItemDto>>().ReverseMap();

    }
}
