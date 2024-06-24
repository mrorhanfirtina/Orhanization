using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Profiles;

public class LocationProductsMappingProfiles : Profile
{
    public LocationProductsMappingProfiles()
    {

        //CreateLocationProductCommand
        CreateMap<CreatedLocationProductResponse, LocationProduct>().ReverseMap();

        //UpdateLocationProductCommand
        CreateMap<UpdatedLocationProductResponse, LocationProduct>().ReverseMap();

        //DeleteLocationProductCommand
        CreateMap<DeletedLocationProductResponse, LocationProduct>().ReverseMap();

        //GetByIdLocationProductQuery
        CreateMap<GetByIdLocationProductResponse, LocationProduct>().ReverseMap();

        //GetListByDynamicLocationProductQuery
        CreateMap<GetListByDynamicLocationProductListItemDto, LocationProduct>().ReverseMap();
        CreateMap<Paginate<LocationProduct>, GetListResponse<GetListByDynamicLocationProductListItemDto>>().ReverseMap();

    }
}
