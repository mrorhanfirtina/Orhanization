using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Profiles;

public class ShipmentTypesMappingProfiles : Profile
{
    public ShipmentTypesMappingProfiles()
    {

        //CreateShipmentTypeCommand
        CreateMap<CreatedShipmentTypeResponse, ShipmentType>().ReverseMap();

        //UpdateShipmentTypeCommand
        CreateMap<UpdatedShipmentTypeResponse, ShipmentType>().ReverseMap();

        //DeleteShipmentTypeCommand
        CreateMap<DeletedShipmentTypeResponse, ShipmentType>().ReverseMap();

        //GetByCodeShipmentTypeQuery
        CreateMap<GetByCodeShipmentTypeResponse, ShipmentType>().ReverseMap();

        //GetByIdShipmentTypeQuery
        CreateMap<GetByIdShipmentTypeResponse, ShipmentType>().ReverseMap();

        //GetListShipmentTypeQuery
        CreateMap<GetListShipmentTypeListItemDto, ShipmentType>().ReverseMap();
        CreateMap<Paginate<ShipmentType>, GetListResponse<GetListShipmentTypeListItemDto>>().ReverseMap();

        //GetListByDynamicShipmentTypeQuery
        CreateMap<GetListByDynamicShipmentTypeListItemDto, ShipmentType>().ReverseMap();
        CreateMap<Paginate<ShipmentType>, GetListResponse<GetListByDynamicShipmentTypeListItemDto>>().ReverseMap();

    }
}

