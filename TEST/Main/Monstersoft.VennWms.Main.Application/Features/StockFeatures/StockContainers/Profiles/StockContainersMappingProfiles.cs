using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Profiles;

public class StockContainersMappingProfiles : Profile
{
    public StockContainersMappingProfiles()
    {

        //CreateStockContainerCommand
        CreateMap<CreatedStockContainerResponse, StockContainer>().ReverseMap();

        //UpdateStockContainerCommand
        CreateMap<UpdatedStockContainerResponse, StockContainer>().ReverseMap();

        //DeleteStockContainerCommand
        CreateMap<DeletedStockContainerResponse, StockContainer>().ReverseMap();

        //GetByIdStockContainerQuery
        CreateMap<GetByIdStockContainerResponse, StockContainer>().ReverseMap();

        //GetListByDynamicStockContainerQuery
        CreateMap<GetListByDynamicStockContainerListItemDto, StockContainer>().ReverseMap();
        CreateMap<Paginate<StockContainer>, GetListResponse<GetListByDynamicStockContainerListItemDto>>().ReverseMap();

    }
}
