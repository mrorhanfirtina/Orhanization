using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Profiles;

public class ReceiptsMappingProfiles : Profile
{
    public ReceiptsMappingProfiles()
    {

        //CreateReceiptCommand
        CreateMap<CreatedReceiptResponse, Receipt>().ReverseMap();

        //UpdateReceiptCommand
        CreateMap<UpdatedReceiptResponse, Receipt>().ReverseMap();

        //DeleteReceiptCommand
        CreateMap<DeletedReceiptResponse, Receipt>().ReverseMap();

        //GetByCodeReceiptQuery
        CreateMap<GetByCodeReceiptResponse, Receipt>().ReverseMap();

        //GetByIdReceiptQuery
        CreateMap<GetByIdReceiptResponse, Receipt>().ReverseMap();

        //GetListReceiptQuery
        CreateMap<GetListReceiptListItemDto, Receipt>().ReverseMap();
        CreateMap<Paginate<Receipt>, GetListResponse<GetListReceiptListItemDto>>().ReverseMap();

        //GetListByDynamicReceiptQuery
        CreateMap<GetListByDynamicReceiptListItemDto, Receipt>().ReverseMap();
        CreateMap<Paginate<Receipt>, GetListResponse<GetListByDynamicReceiptListItemDto>>().ReverseMap();

    }
}
