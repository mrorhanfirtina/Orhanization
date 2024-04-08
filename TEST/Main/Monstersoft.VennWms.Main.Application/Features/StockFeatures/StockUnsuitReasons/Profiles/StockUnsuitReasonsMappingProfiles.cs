using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Profiles;

public class StockUnsuitReasonsMappingProfiles : Profile
{
    public StockUnsuitReasonsMappingProfiles()
    {

        //CreateStockUnsuitReasonCommand
        CreateMap<CreatedStockUnsuitReasonResponse, StockUnsuitReason>().ReverseMap();

        //UpdateStockUnsuitReasonCommand
        CreateMap<UpdatedStockUnsuitReasonResponse, StockUnsuitReason>().ReverseMap();

        //DeleteStockUnsuitReasonCommand
        CreateMap<DeletedStockUnsuitReasonResponse, StockUnsuitReason>().ReverseMap();

        //GetByIdStockUnsuitReasonQuery
        CreateMap<GetByIdStockUnsuitReasonResponse, StockUnsuitReason>().ReverseMap();

        //GetListByDynamicStockUnsuitReasonQuery
        CreateMap<GetListByDynamicStockUnsuitReasonListItemDto, StockUnsuitReason>().ReverseMap();
        CreateMap<Paginate<StockUnsuitReason>, GetListResponse<GetListByDynamicStockUnsuitReasonListItemDto>>().ReverseMap();

    }
}
