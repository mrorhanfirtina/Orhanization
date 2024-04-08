using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Profiles;

public class LocationsMappingProfiles : Profile
{
    public LocationsMappingProfiles()
    {

        //CreateLocationCommand
        CreateMap<CreatedLocationResponse, Location>().ReverseMap();

        //UpdateLocationCommand
        CreateMap<UpdatedLocationResponse, Location>().ReverseMap();

        //DeleteLocationCommand
        CreateMap<DeletedLocationResponse, Location>().ReverseMap();

        //GetByCodeLocationQuery
        CreateMap<GetByCodeLocationResponse, Location>().ReverseMap();

        //GetByIdLocationQuery
        CreateMap<GetByIdLocationResponse, Location>().ReverseMap();

        //GetListLocationQuery
        CreateMap<GetListLocationListItemDto, Location>().ReverseMap();
        CreateMap<Paginate<Location>, GetListResponse<GetListLocationListItemDto>>().ReverseMap();

        //GetListByDynamicLocationQuery
        CreateMap<GetListByDynamicLocationListItemDto, Location>().ReverseMap();
        CreateMap<Paginate<Location>, GetListResponse<GetListByDynamicLocationListItemDto>>().ReverseMap();

    }
}
