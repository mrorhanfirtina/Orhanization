using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Profiles;

public class PurchaseOrdersMappingProfiles : Profile
{
    public PurchaseOrdersMappingProfiles()
    {

        //CreatePurchaseOrderCommand
        CreateMap<CreatedPurchaseOrderResponse, PurchaseOrder>().ReverseMap();

        //UpdatePurchaseOrderCommand
        CreateMap<UpdatedPurchaseOrderResponse, PurchaseOrder>().ReverseMap();

        //DeletePurchaseOrderCommand
        CreateMap<DeletedPurchaseOrderResponse, PurchaseOrder>().ReverseMap();

        //GetByCodePurchaseOrderQuery
        CreateMap<GetByCodePurchaseOrderResponse, PurchaseOrder>().ReverseMap();

        //GetByIdPurchaseOrderQuery
        CreateMap<GetByIdPurchaseOrderResponse, PurchaseOrder>().ReverseMap();

        //GetListPurchaseOrderQuery
        CreateMap<GetListPurchaseOrderListItemDto, PurchaseOrder>().ReverseMap();
        CreateMap<Paginate<PurchaseOrder>, GetListResponse<GetListPurchaseOrderListItemDto>>().ReverseMap();

        //GetListByDynamicPurchaseOrderQuery
        CreateMap<GetListByDynamicPurchaseOrderListItemDto, PurchaseOrder>().ReverseMap();
        CreateMap<Paginate<PurchaseOrder>, GetListResponse<GetListByDynamicPurchaseOrderListItemDto>>().ReverseMap();

    }
}
