using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.DtoProfiles;

public class LogStockDtoMappingProfiles : Profile
{
    public LogStockDtoMappingProfiles()
    {
        CreateMap<LogStock, CreateLogStockDto>().ReverseMap();
        CreateMap<LogStock, CreateLogStockSubDto>().ReverseMap();
        CreateMap<LogStock, UpdateLogStockDto>().ReverseMap();
        CreateMap<LogStock, UpdateLogStockSubDto>().ReverseMap();

        CreateMap<ContainerUnit, LogStockContainerUnitResponseDto>().ReverseMap();
        CreateMap<Location, LogStockLocationResponseDto>().ReverseMap();
        CreateMap<LogStockAttributeValue, LogStockLogStockAttributeValueResponseDto>().ReverseMap();
        CreateMap<LogStockContainer, LogStockLogStockContainerResponseDto>().ReverseMap();
        CreateMap<LogStockReserveReason, LogStockLogStockReserveReasonResponseDto>().ReverseMap();
        CreateMap<LogStockUnsuitReason, LogStockLogStockUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<Product, LogStockProductResponseDto>().ReverseMap();
        CreateMap<ReserveReason, LogStockReserveReasonResponseDto>().ReverseMap();
        CreateMap<StockAttribute, LogStockStockAttributeResponseDto>().ReverseMap();
        CreateMap<TransactionLog, LogStockTransactionLogResponseDto>().ReverseMap();
        CreateMap<TransactionType, LogStockTransactionTypeResponseDto>().ReverseMap();
        CreateMap<UnsuitReason, LogStockUnsuitReasonResponseDto>().ReverseMap();
    }
}
