using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Profiles;

public class OrderAttributesMappingProfiles : Profile
{
    public OrderAttributesMappingProfiles()
    {

        //CreateOrderAttributeCommand
        CreateMap<CreatedOrderAttributeResponse, OrderAttribute>().ReverseMap();

        //UpdateOrderAttributeCommand
        CreateMap<UpdatedOrderAttributeResponse, OrderAttribute>().ReverseMap();

        //DeleteOrderAttributeCommand
        CreateMap<DeletedOrderAttributeResponse, OrderAttribute>().ReverseMap();

        //GetByCodeOrderAttributeQuery
        CreateMap<GetByCodeOrderAttributeResponse, OrderAttribute>().ReverseMap();

        //GetByIdOrderAttributeQuery
        CreateMap<GetByIdOrderAttributeResponse, OrderAttribute>().ReverseMap();

        //GetListOrderAttributeQuery
        CreateMap<GetListOrderAttributeListItemDto, OrderAttribute>().ReverseMap();
        CreateMap<Paginate<OrderAttribute>, GetListResponse<GetListOrderAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicOrderAttributeQuery
        CreateMap<GetListByDynamicOrderAttributeListItemDto, OrderAttribute>().ReverseMap();
        CreateMap<Paginate<OrderAttribute>, GetListResponse<GetListByDynamicOrderAttributeListItemDto>>().ReverseMap();

    }
}

