using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;

public class CreatedLogStockResponse
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
    public DateTime DeletedDate { get; set; }
    public ICollection<LogStockAttributeValue> LogStockAttributeValues { get; set; }
    public ICollection<LogStockContainer> LogStockContainers { get; set; }
    public ICollection<LogStockReserveReason> LogStockReserveReasons { get; set; }
    public ICollection<LogStockUnsuitReason> LogStockUnsuitReasons { get; set; }

}

