using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Profiles;

public class PoAttributeValuesMappingProfiles : Profile
{
    public PoAttributeValuesMappingProfiles()
    {

        //CreatePoAttributeValueCommand
        CreateMap<CreatedPoAttributeValueResponse, PoAttributeValue>().ReverseMap();

        //UpdatePoAttributeValueCommand
        CreateMap<UpdatedPoAttributeValueResponse, PoAttributeValue>().ReverseMap();

        //DeletePoAttributeValueCommand
        CreateMap<DeletedPoAttributeValueResponse, PoAttributeValue>().ReverseMap();

        //GetByIdPoAttributeValueQuery
        CreateMap<GetByIdPoAttributeValueResponse, PoAttributeValue>().ReverseMap();

        //GetListByDynamicPoAttributeValueQuery
        CreateMap<GetListByDynamicPoAttributeValueListItemDto, PoAttributeValue>().ReverseMap();
        CreateMap<Paginate<PoAttributeValue>, GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>().ReverseMap();

    }
}

