using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockAttributeValue : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string? FromValue { get; set; }
    public string? ToValue { get; set; }
    public virtual LogStock? LogStock { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }

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
