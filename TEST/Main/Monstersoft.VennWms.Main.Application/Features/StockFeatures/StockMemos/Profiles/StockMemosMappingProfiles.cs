using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Profiles;

public class StockMemosMappingProfiles : Profile
{
    public StockMemosMappingProfiles()
    {

        //CreateStockMemoCommand
        CreateMap<CreatedStockMemoResponse, StockMemo>().ReverseMap();

        //UpdateStockMemoCommand
        CreateMap<UpdatedStockMemoResponse, StockMemo>().ReverseMap();

        //DeleteStockMemoCommand
        CreateMap<DeletedStockMemoResponse, StockMemo>().ReverseMap();

        //GetByIdStockMemoQuery
        CreateMap<GetByIdStockMemoResponse, StockMemo>().ReverseMap();

        //GetListByDynamicStockMemoQuery
        CreateMap<GetListByDynamicStockMemoListItemDto, StockMemo>().ReverseMap();
        CreateMap<Paginate<StockMemo>, GetListResponse<GetListByDynamicStockMemoListItemDto>>().ReverseMap();

    }
}
