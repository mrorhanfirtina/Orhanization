using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Profiles;

public class ReceiptMemosMappingProfiles : Profile
{
    public ReceiptMemosMappingProfiles()
    {

        //CreateReceiptMemoCommand
        CreateMap<CreatedReceiptMemoResponse, ReceiptMemo>().ReverseMap();

        //UpdateReceiptMemoCommand
        CreateMap<UpdatedReceiptMemoResponse, ReceiptMemo>().ReverseMap();

        //DeleteReceiptMemoCommand
        CreateMap<DeletedReceiptMemoResponse, ReceiptMemo>().ReverseMap();

        //GetByIdReceiptMemoQuery
        CreateMap<GetByIdReceiptMemoResponse, ReceiptMemo>().ReverseMap();

        //GetListByDynamicReceiptMemoQuery
        CreateMap<GetListByDynamicReceiptMemoListItemDto, ReceiptMemo>().ReverseMap();
        CreateMap<Paginate<ReceiptMemo>, GetListResponse<GetListByDynamicReceiptMemoListItemDto>>().ReverseMap();

    }
}
