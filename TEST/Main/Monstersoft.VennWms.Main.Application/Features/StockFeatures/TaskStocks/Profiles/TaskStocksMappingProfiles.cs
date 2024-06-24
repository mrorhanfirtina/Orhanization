using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Profiles;

public class TaskStocksMappingProfiles : Profile
{
    public TaskStocksMappingProfiles()
    {

        //CreateTaskStockCommand
        CreateMap<CreatedTaskStockResponse, TaskStock>().ReverseMap();

        //UpdateTaskStockCommand
        CreateMap<UpdatedTaskStockResponse, TaskStock>().ReverseMap();

        //DeleteTaskStockCommand
        CreateMap<DeletedTaskStockResponse, TaskStock>().ReverseMap();

        //GetByIdTaskStockQuery
        CreateMap<GetByIdTaskStockResponse, TaskStock>().ReverseMap();

        //GetListByDynamicTaskStockQuery
        CreateMap<GetListByDynamicTaskStockListItemDto, TaskStock>().ReverseMap();
        CreateMap<Paginate<TaskStock>, GetListResponse<GetListByDynamicTaskStockListItemDto>>().ReverseMap();

    }
}
