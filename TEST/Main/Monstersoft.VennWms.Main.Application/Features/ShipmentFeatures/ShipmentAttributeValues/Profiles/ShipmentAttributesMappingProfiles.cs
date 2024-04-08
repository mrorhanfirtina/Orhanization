using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Profiles;

public class ShipmentAttributesMappingProfiles : Profile
{
    public ShipmentAttributesMappingProfiles()
    {

        //CreateShipmentAttributeCommand
        CreateMap<CreatedShipmentAttributeResponse, ShipmentAttribute>().ReverseMap();

        //UpdateShipmentAttributeCommand
        CreateMap<UpdatedShipmentAttributeValueResponse, ShipmentAttribute>().ReverseMap();

        //DeleteShipmentAttributeCommand
        CreateMap<DeletedShipmentAttributeValueResponse, ShipmentAttribute>().ReverseMap();

        //GetByIdShipmentAttributeQuery
        CreateMap<GetByIdShipmentAttributeValueResponse, ShipmentAttribute>().ReverseMap();

        //GetListByDynamicShipmentAttributeQuery
        CreateMap<GetListByDynamicShipmentAttributeValueListItemDto, ShipmentAttribute>().ReverseMap();
        CreateMap<Paginate<ShipmentAttribute>, GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto>>().ReverseMap();

    }
}
