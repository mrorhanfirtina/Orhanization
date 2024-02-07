using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStock : Entity<Guid>
{
    public Guid TransactionLogId { get; set; }
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocaitonId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public virtual TransactionLog? TransactionLog { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Location? FromLocation { get; set; }
    public virtual Location? ToLocation { get; set;}
    public virtual TransactionType? TransactionType { get; set; }
    public virtual ICollection<LogStockAttributeValue> LogStockAttributeValues { get; set; }
    public virtual ICollection<LogStockContainer> LogStockContainers { get; set; }
    public virtual ICollection<LogStockReserveReason> LogStockReserveReasons { get; set; }
    public virtual ICollection<LogStockUnsuitReason> LogStockUnsuitReasons { get; set; }

    public LogStock()
    {
        LogStockAttributeValues = new HashSet<LogStockAttributeValue>();
        LogStockContainers = new HashSet<LogStockContainer>();
        LogStockReserveReasons = new HashSet<LogStockReserveReason>();
        LogStockUnsuitReasons = new HashSet<LogStockUnsuitReason>();
    }

    public LogStock(Guid id, Guid transactionLogId, Guid stockId, Guid productId, Guid fromLocaitonId, Guid toLocationId, decimal quantity, int transactionTypeId) : this()
    {
        Id = id;
        TransactionLogId = transactionLogId;
        StockId = stockId;
        ProductId = productId;
        FromLocaitonId = fromLocaitonId;
        ToLocationId = toLocationId;
        Quantity = quantity;
        TransactionTypeId = transactionTypeId;
    }
}
