using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Profiles;

public class LocationProductAbcCategoryMappingProfiles : Profile
{
    public LocationProductAbcCategoryMappingProfiles()
    {
        //CreateLocationProductAbcCategoryCommand
        CreateMap<CreatedLocationProductAbcCategoryResponse, LocationProductAbcCategory>().ReverseMap();

        //UpdateLocationProductAbcCategoryCommand
        CreateMap<UpdatedLocationProductAbcCategoryResponse, LocationProductAbcCategory>().ReverseMap();

        //DeleteLocationProductAbcCategoryCommand
        CreateMap<DeletedLocationProductAbcCategoryResponse, LocationProductAbcCategory>().ReverseMap();

        //GetByIdLocationProductAbcCategoryQuery
        CreateMap<GetByIdLocationProductAbcCategoryResponse, LocationProductAbcCategory>().ReverseMap();

        //GetListByDynamicLocationProductAbcCategoryQuery
        CreateMap<LocationProductAbcCategory, GetListByDynamicLocationProductAbcCategoryListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationProductAbcCategory>, GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>>().ReverseMap();

    }
}

