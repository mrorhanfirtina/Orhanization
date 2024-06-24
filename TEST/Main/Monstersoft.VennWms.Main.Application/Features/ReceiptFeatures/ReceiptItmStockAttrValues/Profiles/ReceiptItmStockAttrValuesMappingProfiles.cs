using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Profiles;

public class ReceiptItmStockAttrValuesMappingProfiles : Profile
{
    public ReceiptItmStockAttrValuesMappingProfiles()
    {

        //CreateReceiptItmStockAttrValueCommand
        CreateMap<CreatedReceiptItmStockAttrValueResponse, ReceiptItmStockAttrValue>().ReverseMap();

        //UpdateReceiptItmStockAttrValueCommand
        CreateMap<UpdatedReceiptItmStockAttrValueResponse, ReceiptItmStockAttrValue>().ReverseMap();

        //DeleteReceiptItmStockAttrValueCommand
        CreateMap<DeletedReceiptItmStockAttrValueResponse, ReceiptItmStockAttrValue>().ReverseMap();

        //GetByIdReceiptItmStockAttrValueQuery
        CreateMap<GetByIdReceiptItmStockAttrValueResponse, ReceiptItmStockAttrValue>().ReverseMap();

        //GetListByDynamicReceiptItmStockAttrValueQuery
        CreateMap<GetListByDynamicReceiptItmStockAttrValueListItemDto, ReceiptItmStockAttrValue>().ReverseMap();
        CreateMap<Paginate<ReceiptItmStockAttrValue>, GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>>().ReverseMap();

    }
}

