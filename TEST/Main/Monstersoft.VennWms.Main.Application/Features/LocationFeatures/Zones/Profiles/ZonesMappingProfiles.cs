using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Profiles;

public class ZonesMappingProfiles : Profile
{
    public ZonesMappingProfiles()
    {

        //CreateZoneCommand
        CreateMap<CreatedZoneResponse, Zone>().ReverseMap();

        //UpdateZoneCommand
        CreateMap<UpdatedZoneResponse, Zone>().ReverseMap();

        //DeleteZoneCommand
        CreateMap<DeletedZoneResponse, Zone>().ReverseMap();

        //GetByCodeZoneQuery
        CreateMap<GetByCodeZoneResponse, Zone>().ReverseMap();

        //GetByIdZoneQuery
        CreateMap<GetByIdZoneResponse, Zone>().ReverseMap();

        //GetListZoneQuery
        CreateMap<GetListZoneListItemDto, Zone>().ReverseMap();
        CreateMap<Paginate<Zone>, GetListResponse<GetListZoneListItemDto>>().ReverseMap();

        //GetListByDynamicZoneQuery
        CreateMap<GetListByDynamicZoneListItemDto, Zone>().ReverseMap();
        CreateMap<Paginate<Zone>, GetListResponse<GetListByDynamicZoneListItemDto>>().ReverseMap();

    }
}

