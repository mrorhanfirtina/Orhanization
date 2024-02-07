using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class Stock : Entity<Guid>
{
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public decimal Quantity { get; set; }
    public decimal FreeQuantity { get; set; }
    public Guid LocationId { get; set; }
    public Guid UnitId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public virtual StockContainer? StockContainer { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Location? Location { get; set; }
    public virtual Unit? Unit { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual Return? Return { get; set; }
    public virtual ICollection<WorkTask> WorkTasks { get; set; }
    public virtual ICollection<StockAttributeValue> StockAttributeValues { get; set; }
    public virtual ICollection<StockMemo> StockMemos { get; set; }
    public virtual ICollection<StockReserveReason> StockReserveReasons { get; set; }
    public virtual ICollection<StockUnsuitReason> StockUnsuitReasons { get; set; }
    public virtual ICollection<TaskStock> TaskStocks { get; set; }

    public Stock()
    {
        WorkTasks = new HashSet<WorkTask>();
        StockAttributeValues = new HashSet<StockAttributeValue>();
        StockMemos = new HashSet<StockMemo>();
        StockReserveReasons = new HashSet<StockReserveReason>();
        StockUnsuitReasons = new HashSet<StockUnsuitReason>();
        TaskStocks = new HashSet<TaskStock>();
    }

    public Stock(Guid id, Guid stockContainerId, Guid productId, Guid depositorId, decimal quantity, decimal freeQuantity, Guid locationId, Guid unitId) : this()
    {
        Id = id;
        StockContainerId = stockContainerId;
        ProductId = productId;
        DepositorId = depositorId;
        Quantity = quantity;
        FreeQuantity = freeQuantity;
        LocationId = locationId;
        UnitId = unitId;
    }
}
