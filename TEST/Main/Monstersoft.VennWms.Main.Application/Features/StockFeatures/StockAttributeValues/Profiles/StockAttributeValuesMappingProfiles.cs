using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Profiles;

public class StockAttributeValuesMappingProfiles : Profile
{
    public StockAttributeValuesMappingProfiles()
    {

        //CreateStockAttributeValueCommand
        CreateMap<CreatedStockAttributeValueResponse, StockAttributeValue>().ReverseMap();

        //UpdateStockAttributeValueCommand
        CreateMap<UpdatedStockAttributeValueResponse, StockAttributeValue>().ReverseMap();

        //DeleteStockAttributeValueCommand
        CreateMap<DeletedStockAttributeValueResponse, StockAttributeValue>().ReverseMap();

        //GetByIdStockAttributeValueQuery
        CreateMap<GetByIdStockAttributeValueResponse, StockAttributeValue>().ReverseMap();

        //GetListByDynamicStockAttributeValueQuery
        CreateMap<GetListByDynamicStockAttributeValueListItemDto, StockAttributeValue>().ReverseMap();
        CreateMap<Paginate<StockAttributeValue>, GetListResponse<GetListByDynamicStockAttributeValueListItemDto>>().ReverseMap();

    }
}

