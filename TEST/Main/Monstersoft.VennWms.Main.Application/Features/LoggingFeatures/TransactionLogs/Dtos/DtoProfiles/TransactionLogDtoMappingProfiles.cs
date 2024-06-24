using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.DtoProfiles;

public class TransactionLogDtoMappingProfiles : Profile
{
    public TransactionLogDtoMappingProfiles()
    {
        CreateMap<TransactionLog, CreateTransactionLogDto>().ReverseMap();
        CreateMap<TransactionLog, UpdateTransactionLogDto>().ReverseMap();

        CreateMap<Company, TransactionLogCompanyResponseDto>().ReverseMap();
        CreateMap<ContainerUnit, TransactionLogContainerUnitResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, TransactionLogDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, TransactionLogDepositorResponseDto>().ReverseMap();
        CreateMap<Location, TransactionLogLocationResponseDto>().ReverseMap();
        CreateMap<LogStockAttributeValue, TransactionLogLogStockAttributeValueResponseDto>().ReverseMap();
        CreateMap<LogStockContainer, TransactionLogLogStockContainerResponseDto>().ReverseMap();
        CreateMap<LogStockReserveReason, TransactionLogLogStockReserveReasonResponseDto>().ReverseMap();
        CreateMap<LogStock, TransactionLogLogStockResponseDto>().ReverseMap();
        CreateMap<LogStockUnsuitReason, TransactionLogLogStockUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<Product, TransactionLogProductResponseDto>().ReverseMap();
        CreateMap<ReserveReason, TransactionLogReserveReasonResponseDto>().ReverseMap();
        CreateMap<StockAttribute, TransactionLogStockAttributeResponseDto>().ReverseMap();
        CreateMap<TransactionType, TransactionLogTransactionTypeResponseDto>().ReverseMap();
        CreateMap<UnsuitReason, TransactionLogUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<User, TransactionLogUserResponseDto>().ReverseMap();
    }
}
