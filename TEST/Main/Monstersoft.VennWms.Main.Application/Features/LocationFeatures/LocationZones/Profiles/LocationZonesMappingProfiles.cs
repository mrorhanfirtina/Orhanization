using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Profiles;

public class LocationZonesMappingProfiles : Profile
{
    public LocationZonesMappingProfiles()
    {

        //CreateLocationZoneCommand
        CreateMap<CreatedLocationZoneResponse, LocationZone>().ReverseMap();

        //UpdateLocationZoneCommand
        CreateMap<UpdatedLocationZoneResponse, LocationZone>().ReverseMap();

        //DeleteLocationZoneCommand
        CreateMap<DeletedLocationZoneResponse, LocationZone>().ReverseMap();

        //GetByIdLocationZoneQuery
        CreateMap<GetByIdLocationZoneResponse, LocationZone>().ReverseMap();

        //GetListByDynamicLocationZoneQuery
        CreateMap<GetListByDynamicLocationZoneListItemDto, LocationZone>().ReverseMap();
        CreateMap<Paginate<LocationZone>, GetListResponse<GetListByDynamicLocationZoneListItemDto>>().ReverseMap();

    }
}

