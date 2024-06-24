using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Profiles;

public class StockReserveReasonsMappingProfiles : Profile
{
    public StockReserveReasonsMappingProfiles()
    {

        //CreateStockReserveReasonCommand
        CreateMap<CreatedStockReserveReasonResponse, StockReserveReason>().ReverseMap();

        //UpdateStockReserveReasonCommand
        CreateMap<UpdatedStockReserveReasonResponse, StockReserveReason>().ReverseMap();

        //DeleteStockReserveReasonCommand
        CreateMap<DeletedStockReserveReasonResponse, StockReserveReason>().ReverseMap();

        //GetByIdStockReserveReasonQuery
        CreateMap<GetByIdStockReserveReasonResponse, StockReserveReason>().ReverseMap();

        //GetListByDynamicStockReserveReasonQuery
        CreateMap<GetListByDynamicStockReserveReasonListItemDto, StockReserveReason>().ReverseMap();
        CreateMap<Paginate<StockReserveReason>, GetListResponse<GetListByDynamicStockReserveReasonListItemDto>>().ReverseMap();

    }
}

