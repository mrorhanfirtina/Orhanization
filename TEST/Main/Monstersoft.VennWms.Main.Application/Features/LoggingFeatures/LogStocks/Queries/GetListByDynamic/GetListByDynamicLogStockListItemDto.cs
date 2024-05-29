using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetListByDynamic;

public class GetListByDynamicLogStockListItemDto
{
    public Guid Id { get; set; }
    public Guid TransactionLogId { get; set; }
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocaitonId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LogStockTransactionLogResponseDto? TransactionLog { get; set; }
    public LogStockProductResponseDto? Product { get; set; }
    public LogStockLocationResponseDto? FromLocation { get; set; }
    public LogStockLocationResponseDto? ToLocation { get; set; }
    public LogStockTransactionTypeResponseDto? TransactionType { get; set; }
    public ICollection<LogStockLogStockAttributeValueResponseDto>? LogStockAttributeValues { get; set; }
    public ICollection<LogStockLogStockContainerResponseDto>? LogStockContainers { get; set; }
    public ICollection<LogStockLogStockReserveReasonResponseDto>? LogStockReserveReasons { get; set; }
    public ICollection<LogStockLogStockUnsuitReasonResponseDto>? LogStockUnsuitReasons { get; set; }

}

