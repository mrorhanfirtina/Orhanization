using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Profiles;

public class LocationProductConstraintMappingProfiles : Profile
{
    public LocationProductConstraintMappingProfiles()
    {
        //CreateLocationProductConstraintCommand
        CreateMap<CreatedLocationProductConstraintResponse, LocationProductConstraint>().ReverseMap();

        //UpdateLocationProductConstraintCommand
        CreateMap<UpdatedLocationProductConstraintResponse, LocationProductConstraint>().ReverseMap();

        //DeleteLocationProductConstraintCommand
        CreateMap<DeletedLocationProductConstraintResponse, LocationProductConstraint>().ReverseMap();

        //GetByIdLocationProductConstraintQuery
        CreateMap<GetByIdLocationProductConstraintResponse, LocationProductConstraint>().ReverseMap();

        //GetListByDynamicLocationProductConstraintQuery
        CreateMap<LocationProductConstraint, GetListByDynamicLocationProductConstraintListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationProductConstraint>, GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>>().ReverseMap();

    }
}

