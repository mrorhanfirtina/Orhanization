using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.DtoProfiles;

public class TaskStockDtoMappingProfiles : Profile
{
    public TaskStockDtoMappingProfiles()
    {
        CreateMap<TaskStock, CreateTaskStockDto>().ReverseMap();
        CreateMap<TaskStock, UpdateTaskStockDto>().ReverseMap();
    }
}
