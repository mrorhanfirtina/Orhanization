using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Profiles;

public class LocationUnitConstraintMappingProfiles : Profile
{
    public LocationUnitConstraintMappingProfiles()
    {
        //CreateLocationUnitConstraintCommand
        CreateMap<CreatedLocationUnitConstraintResponse, LocationUnitConstraint>().ReverseMap();

        //UpdateLocationUnitConstraintCommand
        CreateMap<UpdatedLocationUnitConstraintResponse, LocationUnitConstraint>().ReverseMap();

        //DeleteLocationUnitConstraintCommand
        CreateMap<DeletedLocationUnitConstraintResponse, LocationUnitConstraint>().ReverseMap();

        //GetByIdLocationUnitConstraintQuery
        CreateMap<GetByIdLocationUnitConstraintResponse, LocationUnitConstraint>().ReverseMap();

        //GetListByDynamicLocationUnitConstraintQuery
        CreateMap<LocationUnitConstraint, GetListByDynamicLocationUnitConstraintListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationUnitConstraint>, GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>>().ReverseMap();

    }
}

