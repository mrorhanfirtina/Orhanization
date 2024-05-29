namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogLogStockResponseDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocaitonId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public TransactionLogProductResponseDto? Product { get; set; }
    public TransactionLogLocationResponseDto? FromLocation { get; set; }
    public TransactionLogLocationResponseDto? ToLocation { get; set; }
    public TransactionLogTransactionTypeResponseDto? TransactionType { get; set; }
    public ICollection<TransactionLogLogStockAttributeValueResponseDto>? LogStockAttributeValues { get; set; }
    public ICollection<TransactionLogLogStockContainerResponseDto>? LogStockContainers { get; set; }
    public ICollection<TransactionLogLogStockReserveReasonResponseDto>? LogStockReserveReasons { get; set; }
    public ICollection<TransactionLogLogStockUnsuitReasonResponseDto>? LogStockUnsuitReasons { get; set; }
}
