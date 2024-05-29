using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Profiles;

public class LocationProductCategoryMappingProfiles : Profile
{
    public LocationProductCategoryMappingProfiles()
    {
        //CreateLocationProductCategoryCommand
        CreateMap<CreatedLocationProductCategoryResponse, LocationProductCategory>().ReverseMap();

        //UpdateLocationProductCategoryCommand
        CreateMap<UpdatedLocationProductCategoryResponse, LocationProductCategory>().ReverseMap();

        //DeleteLocationProductCategoryCommand
        CreateMap<DeletedLocationProductCategoryResponse, LocationProductCategory>().ReverseMap();

        //GetByIdLocationProductCategoryQuery
        CreateMap<GetByIdLocationProductCategoryResponse, LocationProductCategory>().ReverseMap();

        //GetListByDynamicLocationProductCategoryQuery
        CreateMap<LocationProductCategory, GetListByDynamicLocationProductCategoryListItemDto>().ReverseMap();
        CreateMap<Paginate<LocationProductCategory>, GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>>().ReverseMap();

    }
}

