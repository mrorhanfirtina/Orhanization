using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Profiles;

public class StockAttributesMappingProfiles : Profile
{
    public StockAttributesMappingProfiles()
    {

        //CreateStockAttributeCommand
        CreateMap<CreatedStockAttributeResponse, StockAttribute>().ReverseMap();

        //UpdateStockAttributeCommand
        CreateMap<UpdatedStockAttributeResponse, StockAttribute>().ReverseMap();

        //DeleteStockAttributeCommand
        CreateMap<DeletedStockAttributeResponse, StockAttribute>().ReverseMap();

        //GetByCodeStockAttributeQuery
        CreateMap<GetByCodeStockAttributeResponse, StockAttribute>().ReverseMap();

        //GetByIdStockAttributeQuery
        CreateMap<GetByIdStockAttributeResponse, StockAttribute>().ReverseMap();

        //GetListStockAttributeQuery
        CreateMap<GetListStockAttributeListItemDto, StockAttribute>().ReverseMap();
        CreateMap<Paginate<StockAttribute>, GetListResponse<GetListStockAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicStockAttributeQuery
        CreateMap<GetListByDynamicStockAttributeListItemDto, StockAttribute>().ReverseMap();
        CreateMap<Paginate<StockAttribute>, GetListResponse<GetListByDynamicStockAttributeListItemDto>>().ReverseMap();

    }
}
