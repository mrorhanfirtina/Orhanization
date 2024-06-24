using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Profiles;

public class StocksMappingProfiles : Profile
{
    public StocksMappingProfiles()
    {

        //CreateStockCommand
        CreateMap<CreatedStockResponse, Stock>().ReverseMap();

        //UpdateStockCommand
        CreateMap<UpdatedStockResponse, Stock>().ReverseMap();

        //DeleteStockCommand
        CreateMap<DeletedStockResponse, Stock>().ReverseMap();

        //GetByIdStockQuery
        CreateMap<GetByIdStockResponse, Stock>().ReverseMap();

        //GetListStockQuery
        CreateMap<GetListStockListItemDto, Stock>().ReverseMap();
        CreateMap<Paginate<Stock>, GetListResponse<GetListStockListItemDto>>().ReverseMap();

        //GetListByDynamicStockQuery
        CreateMap<GetListByDynamicStockListItemDto, Stock>().ReverseMap();
        CreateMap<Paginate<Stock>, GetListResponse<GetListByDynamicStockListItemDto>>().ReverseMap();

    }
}

