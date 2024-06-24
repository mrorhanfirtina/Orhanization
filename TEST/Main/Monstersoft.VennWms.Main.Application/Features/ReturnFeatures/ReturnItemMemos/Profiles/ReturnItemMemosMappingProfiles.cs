using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Profiles;

public class ReturnItemMemosMappingProfiles : Profile
{
    public ReturnItemMemosMappingProfiles()
    {

        //CreateReturnItemMemoCommand
        CreateMap<CreatedReturnItemMemoResponse, ReturnItemMemo>().ReverseMap();

        //UpdateReturnItemMemoCommand
        CreateMap<UpdatedReturnItemMemoResponse, ReturnItemMemo>().ReverseMap();

        //DeleteReturnItemMemoCommand
        CreateMap<DeletedReturnItemMemoResponse, ReturnItemMemo>().ReverseMap();

        //GetByIdReturnItemMemoQuery
        CreateMap<GetByIdReturnItemMemoResponse, ReturnItemMemo>().ReverseMap();

        //GetListByDynamicReturnItemMemoQuery
        CreateMap<GetListByDynamicReturnItemMemoListItemDto, ReturnItemMemo>().ReverseMap();
        CreateMap<Paginate<ReturnItemMemo>, GetListResponse<GetListByDynamicReturnItemMemoListItemDto>>().ReverseMap();

    }
}

