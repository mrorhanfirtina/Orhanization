using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.DtoProfiles;

public class WorkTaskDtoMappingProfiles : Profile
{
    public WorkTaskDtoMappingProfiles()
    {
        CreateMap<WorkTask, CreateWorkTaskDto>().ReverseMap();
        CreateMap<WorkTask, CreateWorkTaskSubDto>().ReverseMap();
        CreateMap<WorkTask, UpdateWorkTaskDto>().ReverseMap();
        CreateMap<WorkTask, UpdateWorkTaskSubDto>().ReverseMap();

        CreateMap<Company, WorkTasksCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, WorkTasksDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, WorkTasksDepositorResponseDto>().ReverseMap();
        CreateMap<Location, WorkTasksFromLocationResponseDto>().ReverseMap();
        CreateMap<OrderShipItemTask, WorkTasksOrderShipItemTaskResponseDto>().ReverseMap();
        CreateMap<Product, WorkTasksProductResponseDto>().ReverseMap();
        CreateMap<Status, WorkTasksStatusResponseDto>().ReverseMap();
        CreateMap<Stock, WorkTasksStockResponseDto>().ReverseMap();
        CreateMap<Location, WorkTasksToLocationResponseDto>().ReverseMap();
        CreateMap<TransactionType, WorkTasksTransactionTypeResponseDto>().ReverseMap();
    }
}
