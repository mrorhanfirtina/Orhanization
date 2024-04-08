using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Profiles;

public class ReturnMemosMappingProfiles : Profile
{
    public ReturnMemosMappingProfiles()
    {

        //CreateReturnMemoCommand
        CreateMap<CreatedReturnMemoResponse, ReturnMemo>().ReverseMap();

        //UpdateReturnMemoCommand
        CreateMap<UpdatedReturnMemoResponse, ReturnMemo>().ReverseMap();

        //DeleteReturnMemoCommand
        CreateMap<DeletedReturnMemoResponse, ReturnMemo>().ReverseMap();

        //GetByIdReturnMemoQuery
        CreateMap<GetByIdReturnMemoResponse, ReturnMemo>().ReverseMap();

        //GetListByDynamicReturnMemoQuery
        CreateMap<GetListByDynamicReturnMemoListItemDto, ReturnMemo>().ReverseMap();
        CreateMap<Paginate<ReturnMemo>, GetListResponse<GetListByDynamicReturnMemoListItemDto>>().ReverseMap();

    }
}
