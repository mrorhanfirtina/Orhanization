using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Profiles;

public class ShipmentAttributesMappingProfiles : Profile
{
    public ShipmentAttributesMappingProfiles()
    {

        //CreateShipmentAttributeCommand
        CreateMap<CreatedShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //UpdateShipmentAttributeCommand
        CreateMap<UpdatedShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //DeleteShipmentAttributeCommand
        CreateMap<DeletedShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //GetByCodeShipmentAttributeQuery
        CreateMap<GetByCodeShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //GetByIdShipmentAttributeQuery
        CreateMap<GetByIdShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //GetListShipmentAttributeQuery
        CreateMap<GetListShipmentAttributeListItemDto, ShipmentAttribute>().ReverseMap();
        CreateMap<Paginate<ShipmentAttribute>, GetListResponse<GetListShipmentAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicShipmentAttributeQuery
        CreateMap<GetListByDynamicShipmentAttributeListItemDto, ShipmentAttribute>().ReverseMap();
        CreateMap<Paginate<ShipmentAttribute>, GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>().ReverseMap();

    }
}
