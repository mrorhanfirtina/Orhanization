using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Profiles;

public class StockContainerHierarchiesMappingProfiles : Profile
{
    public StockContainerHierarchiesMappingProfiles()
    {

        //CreateStockContainerHierarchyCommand	
        CreateMap<CreatedStockContainerHierarchyResponse, StockContainerHierarchy>().ReverseMap();

        //UpdateStockContainerHierarchyCommand	
        CreateMap<UpdatedStockContainerHierarchyResponse, StockContainerHierarchy>().ReverseMap();

        //DeleteStockContainerHierarchyCommand	
        CreateMap<DeletedStockContainerHierarchyResponse, StockContainerHierarchy>().ReverseMap();

        //GetByIdStockContainerHierarchyQuery	
        CreateMap<GetByIdStockContainerHierarchyResponse, StockContainerHierarchy>().ReverseMap();

        //GetListByDynamicStockContainerHierarchyQuery	
        CreateMap<GetListByDynamicStockContainerHierarchyListItemDto, StockContainerHierarchy>().ReverseMap();
        CreateMap<Paginate<StockContainerHierarchy>, GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>>().ReverseMap();

    }
}
