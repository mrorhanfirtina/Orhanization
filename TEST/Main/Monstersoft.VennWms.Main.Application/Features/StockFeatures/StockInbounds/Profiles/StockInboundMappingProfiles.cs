using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Profiles;

public class StockInboundMappingProfiles : Profile
{
    public StockInboundMappingProfiles()
    {
        //CreateStockInboundCommand
        CreateMap<CreatedStockInboundResponse, StockInbound>().ReverseMap();

        //UpdateStockInboundCommand
        CreateMap<UpdatedStockInboundResponse, StockInbound>().ReverseMap();

        //DeleteStockInboundCommand
        CreateMap<DeletedStockInboundResponse, StockInbound>().ReverseMap();

        //GetByIdStockInboundQuery
        CreateMap<GetByIdStockInboundResponse, StockInbound>().ReverseMap();

        //GetListByDynamicStockInboundQuery
        CreateMap<StockInbound, GetListByDynamicStockInboundListItemDto>().ReverseMap();
        CreateMap<Paginate<StockInbound>, GetListResponse<GetListByDynamicStockInboundListItemDto>>().ReverseMap();

    }
}
