using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Profiles;

public class PoTypesMappingProfiles : Profile
{
    public PoTypesMappingProfiles()
    {

        //CreatePoTypeCommand
        CreateMap<CreatedPoTypeResponse, PoType>().ReverseMap();

        //UpdatePoTypeCommand
        CreateMap<UpdatedPoTypeResponse, PoType>().ReverseMap();

        //DeletePoTypeCommand
        CreateMap<DeletedPoTypeResponse, PoType>().ReverseMap();

        //GetByCodePoTypeQuery
        CreateMap<GetByCodePoTypeResponse, PoType>().ReverseMap();

        //GetByIdPoTypeQuery
        CreateMap<GetByIdPoTypeResponse, PoType>().ReverseMap();

        //GetListPoTypeQuery
        CreateMap<GetListPoTypeListItemDto, PoType>().ReverseMap();
        CreateMap<Paginate<PoType>, GetListResponse<GetListPoTypeListItemDto>>().ReverseMap();

        //GetListByDynamicPoTypeQuery
        CreateMap<GetListByDynamicPoTypeListItemDto, PoType>().ReverseMap();
        CreateMap<Paginate<PoType>, GetListResponse<GetListByDynamicPoTypeListItemDto>>().ReverseMap();

    }
}
