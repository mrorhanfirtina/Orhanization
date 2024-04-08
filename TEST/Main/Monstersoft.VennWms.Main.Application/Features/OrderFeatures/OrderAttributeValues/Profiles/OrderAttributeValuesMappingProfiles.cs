using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Profiles;

public class OrderAttributeValuesMappingProfiles : Profile
{
    public OrderAttributeValuesMappingProfiles()
    {

        //CreateOrderAttributeValueCommand
        CreateMap<CreatedOrderAttributeValueResponse, OrderAttributeValue>().ReverseMap();

        //UpdateOrderAttributeValueCommand
        CreateMap<UpdatedOrderAttributeValueResponse, OrderAttributeValue>().ReverseMap();

        //DeleteOrderAttributeValueCommand
        CreateMap<DeletedOrderAttributeValueResponse, OrderAttributeValue>().ReverseMap();

        //GetByIdOrderAttributeValueQuery
        CreateMap<GetByIdOrderAttributeValueResponse, OrderAttributeValue>().ReverseMap();

        //GetListByDynamicOrderAttributeValueQuery
        CreateMap<GetListByDynamicOrderAttributeValueListItemDto, OrderAttributeValue>().ReverseMap();
        CreateMap<Paginate<OrderAttributeValue>, GetListResponse<GetListByDynamicOrderAttributeValueListItemDto>>().ReverseMap();

    }
}
