using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Profiles;

public class ShipmentsMappingProfiles : Profile
{
    public ShipmentsMappingProfiles()
    {

        //CreateShipmentCommand
        CreateMap<CreatedShipmentResponse, Shipment>().ReverseMap();

        //UpdateShipmentCommand
        CreateMap<UpdatedShipmentResponse, Shipment>().ReverseMap();

        //DeleteShipmentCommand
        CreateMap<DeletedShipmentResponse, Shipment>().ReverseMap();

        //GetByCodeShipmentQuery
        CreateMap<GetByCodeShipmentResponse, Shipment>().ReverseMap();

        //GetByIdShipmentQuery
        CreateMap<GetByIdShipmentResponse, Shipment>().ReverseMap();

        //GetListShipmentQuery
        CreateMap<GetListShipmentListItemDto, Shipment>().ReverseMap();
        CreateMap<Paginate<Shipment>, GetListResponse<GetListShipmentListItemDto>>().ReverseMap();

        //GetListByDynamicShipmentQuery
        CreateMap<GetListByDynamicShipmentListItemDto, Shipment>().ReverseMap();
        CreateMap<Paginate<Shipment>, GetListResponse<GetListByDynamicShipmentListItemDto>>().ReverseMap();

    }
}
