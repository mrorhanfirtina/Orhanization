using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Profiles;

public class PoAttributesMappingProfiles : Profile
{
    public PoAttributesMappingProfiles()
    {

        //CreatePoAttributeCommand
        CreateMap<CreatedPoAttributeResponse, PoAttribute>().ReverseMap();

        //UpdatePoAttributeCommand
        CreateMap<UpdatedPoAttributeResponse, PoAttribute>().ReverseMap();

        //DeletePoAttributeCommand
        CreateMap<DeletedPoAttributeResponse, PoAttribute>().ReverseMap();

        //GetByCodePoAttributeQuery
        CreateMap<GetByCodePoAttributeResponse, PoAttribute>().ReverseMap();

        //GetByIdPoAttributeQuery
        CreateMap<GetByIdPoAttributeResponse, PoAttribute>().ReverseMap();

        //GetListPoAttributeQuery
        CreateMap<GetListPoAttributeListItemDto, PoAttribute>().ReverseMap();
        CreateMap<Paginate<PoAttribute>, GetListResponse<GetListPoAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicPoAttributeQuery
        CreateMap<GetListByDynamicPoAttributeListItemDto, PoAttribute>().ReverseMap();
        CreateMap<Paginate<PoAttribute>, GetListResponse<GetListByDynamicPoAttributeListItemDto>>().ReverseMap();

    }
}

