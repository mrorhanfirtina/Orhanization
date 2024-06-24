using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Profiles;

public class ReceiptItemMemosMappingProfiles : Profile
{
    public ReceiptItemMemosMappingProfiles()
    {

        //CreateReceiptItemMemoCommand
        CreateMap<CreatedReceiptItemMemoResponse, ReceiptItemMemo>().ReverseMap();

        //UpdateReceiptItemMemoCommand
        CreateMap<UpdatedReceiptItemMemoResponse, ReceiptItemMemo>().ReverseMap();

        //DeleteReceiptItemMemoCommand
        CreateMap<DeletedReceiptItemMemoResponse, ReceiptItemMemo>().ReverseMap();

        //GetByIdReceiptItemMemoQuery
        CreateMap<GetByIdReceiptItemMemoResponse, ReceiptItemMemo>().ReverseMap();

        //GetListByDynamicReceiptItemMemoQuery
        CreateMap<GetListByDynamicReceiptItemMemoListItemDto, ReceiptItemMemo>().ReverseMap();
        CreateMap<Paginate<ReceiptItemMemo>, GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>().ReverseMap();
    }
}
