using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Profiles;

public class LocationLockReasonMappingProfiles : Profile
{
    public LocationLockReasonMappingProfiles()
    {
        //CreateLocationLockReasonCommand
        CreateMap<CreatedLocationLockReasonResponse, LocationLockReason>().ReverseMap();

        //UpdateLocationLockReasonCommand
        CreateMap<UpdatedLocationLockReasonResponse, LocationLockReason>().ReverseMap();

        //DeleteLocationLockReasonCommand
        CreateMap<DeletedLocationLockReasonResponse, LocationLockReason>().ReverseMap();

        //GetByIdLocationLockReasonQuery
        CreateMap<GetByIdLocationLockReasonResponse, LocationLockReason>().ReverseMap();

        //GetListByDynamicLocationLockReasonQuery
        CreateMap<LocationLockReason, GetListByDynamicLocationLockReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationLockReason>, GetListResponse<GetListByDynamicLocationLockReasonListItemDto>>().ReverseMap();

    }
}


