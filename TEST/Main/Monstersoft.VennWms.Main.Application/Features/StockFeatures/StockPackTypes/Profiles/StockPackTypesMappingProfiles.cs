using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Profiles;

public class StockPackTypesMappingProfiles : Profile
{
    public StockPackTypesMappingProfiles()
    {

        //CreateStockPackTypeCommand
        CreateMap<CreatedStockPackTypeResponse, StockPackType>().ReverseMap();

        //UpdateStockPackTypeCommand
        CreateMap<UpdatedStockPackTypeResponse, StockPackType>().ReverseMap();

        //DeleteStockPackTypeCommand
        CreateMap<DeletedStockPackTypeResponse, StockPackType>().ReverseMap();

        //GetByIdStockPackTypeQuery
        CreateMap<GetByIdStockPackTypeResponse, StockPackType>().ReverseMap();

        //GetListByDynamicStockPackTypeQuery
        CreateMap<GetListByDynamicStockPackTypeListItemDto, StockPackType>().ReverseMap();
        CreateMap<Paginate<StockPackType>, GetListResponse<GetListByDynamicStockPackTypeListItemDto>>().ReverseMap();

    }
}

