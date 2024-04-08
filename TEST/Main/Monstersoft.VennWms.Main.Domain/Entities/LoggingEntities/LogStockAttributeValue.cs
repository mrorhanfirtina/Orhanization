using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockAttributeValue : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string? FromValue { get; set; }
    public string? ToValue { get; set; }

    public LogStockAttributeValue()
    {
    }

    public LogStockAttributeValue(Guid id, Guid logStockId, Guid stockAttributeId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        StockAttributeId = stockAttributeId;
    }
}
