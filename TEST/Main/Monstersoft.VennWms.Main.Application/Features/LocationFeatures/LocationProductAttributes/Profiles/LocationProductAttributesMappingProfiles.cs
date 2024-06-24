using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Profiles;

public class LocationProductAttributesMappingProfiles : Profile
{
    public LocationProductAttributesMappingProfiles()
    {

        //CreateLocationProductAttributeCommand
        CreateMap<CreatedLocationProductAttributeResponse, LocationProductAttribute>().ReverseMap();

        //UpdateLocationProductAttributeCommand
        CreateMap<UpdatedLocationProductAttributeResponse, LocationProductAttribute>().ReverseMap();

        //DeleteLocationProductAttributeCommand
        CreateMap<DeletedLocationProductAttributeResponse, LocationProductAttribute>().ReverseMap();

        //GetByIdLocationProductAttributeQuery
        CreateMap<GetByIdLocationProductAttributeResponse, LocationProductAttribute>().ReverseMap();

        //GetListByDynamicLocationProductAttributeQuery
        CreateMap<GetListByDynamicLocationProductAttributeListItemDto, LocationProductAttribute>().ReverseMap();
        CreateMap<Paginate<LocationProductAttribute>, GetListResponse<GetListByDynamicLocationProductAttributeListItemDto>>().ReverseMap();

    }
}

