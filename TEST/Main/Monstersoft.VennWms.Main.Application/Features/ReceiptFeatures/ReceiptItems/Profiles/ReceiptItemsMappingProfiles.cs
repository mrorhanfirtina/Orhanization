using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Profiles;

public class ReceiptItemsMappingProfiles : Profile
{
    public ReceiptItemsMappingProfiles()
    {

        //CreateReceiptItemCommand
        CreateMap<CreatedReceiptItemResponse, ReceiptItem>().ReverseMap();

        //UpdateReceiptItemCommand
        CreateMap<UpdatedReceiptItemResponse, ReceiptItem>().ReverseMap();

        //DeleteReceiptItemCommand
        CreateMap<DeletedReceiptItemResponse, ReceiptItem>().ReverseMap();

        //GetByIdReceiptItemQuery
        CreateMap<GetByIdReceiptItemResponse, ReceiptItem>().ReverseMap();

        //GetListByDynamicReceiptItemQuery
        CreateMap<GetListByDynamicReceiptItemListItemDto, ReceiptItem>().ReverseMap();
        CreateMap<Paginate<ReceiptItem>, GetListResponse<GetListByDynamicReceiptItemListItemDto>>().ReverseMap();

    }
}
