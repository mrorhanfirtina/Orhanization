using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Profiles;

public class LocationDepositorMappingProfiles : Profile
{
    public LocationDepositorMappingProfiles()
    {
        //CreateLocationDepositorCommand
        CreateMap<CreatedLocationDepositorResponse, LocationDepositor>().ReverseMap();

        //UpdateLocationDepositorCommand
        CreateMap<UpdatedLocationDepositorResponse, LocationDepositor>().ReverseMap();

        //DeleteLocationDepositorCommand
        CreateMap<DeletedLocationDepositorResponse, LocationDepositor>().ReverseMap();

        //GetByIdLocationDepositorQuery
        CreateMap<GetByIdLocationDepositorResponse, LocationDepositor>().ReverseMap();

        //GetListByDynamicLocationDepositorQuery
        CreateMap<LocationDepositor, GetListByDynamicLocationDepositorListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationDepositor>, GetListResponse<GetListByDynamicLocationDepositorListItemDto>>().ReverseMap();

    }
}

