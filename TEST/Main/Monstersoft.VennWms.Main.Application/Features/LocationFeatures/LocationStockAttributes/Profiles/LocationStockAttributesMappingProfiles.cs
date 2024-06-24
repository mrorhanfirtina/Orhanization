using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Profiles;

public class LocationStockAttributesMappingProfiles : Profile
{
    public LocationStockAttributesMappingProfiles()
    {

        //CreateLocationStockAttributeCommand
        CreateMap<CreatedLocationStockAttributeResponse, LocationStockAttribute>().ReverseMap();

        //UpdateLocationStockAttributeCommand
        CreateMap<UpdatedLocationStockAttributeResponse, LocationStockAttribute>().ReverseMap();

        //DeleteLocationStockAttributeCommand
        CreateMap<DeletedLocationStockAttributeResponse, LocationStockAttribute>().ReverseMap();

        //GetByIdLocationStockAttributeQuery
        CreateMap<GetByIdLocationStockAttributeResponse, LocationStockAttribute>().ReverseMap();

        //GetListByDynamicLocationStockAttributeQuery
        CreateMap<GetListByDynamicLocationStockAttributeListItemDto, LocationStockAttribute>().ReverseMap();
        CreateMap<Paginate<LocationStockAttribute>, GetListResponse<GetListByDynamicLocationStockAttributeListItemDto>>().ReverseMap();

    }
}

