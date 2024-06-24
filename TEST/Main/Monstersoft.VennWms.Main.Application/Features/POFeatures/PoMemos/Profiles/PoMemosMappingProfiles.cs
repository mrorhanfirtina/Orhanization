using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Profiles;

public class PoMemosMappingProfiles : Profile
{
    public PoMemosMappingProfiles()
    {

        //CreatePoMemoCommand
        CreateMap<CreatedPoMemoResponse, PoMemo>().ReverseMap();

        //UpdatePoMemoCommand
        CreateMap<UpdatedPoMemoResponse, PoMemo>().ReverseMap();

        //DeletePoMemoCommand
        CreateMap<DeletedPoMemoResponse, PoMemo>().ReverseMap();

        //GetByIdPoMemoQuery
        CreateMap<GetByIdPoMemoResponse, PoMemo>().ReverseMap();

        //GetListByDynamicPoMemoQuery
        CreateMap<GetListByDynamicPoMemoListItemDto, PoMemo>().ReverseMap();
        CreateMap<Paginate<PoMemo>, GetListResponse<GetListByDynamicPoMemoListItemDto>>().ReverseMap();

    }
}
