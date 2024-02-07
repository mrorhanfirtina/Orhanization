using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class WorkTask : Entity<Guid>
{
    public string Code { get; set; }
    public Guid TaskListId { get; set; }
    public Guid StockId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocaitonId { get; set; }
    public int StatusId { get; set; }
    public int TransactionTypeId { get; set; }
    public decimal Quantity { get; set; }
    public Guid DepositorId { get; set; }
    public virtual TaskList? TaskList { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual Status? Status { get; set; }
    public virtual TransactionType? TransactionType { get; set; }
    public virtual ICollection<TransactionLog> TransactionLogs { get; set; }

    public WorkTask()
    {
        TransactionLogs = new HashSet<TransactionLog>();
    }

    public WorkTask(Guid id, string code, Guid taskListId, Guid stockId, Guid fromLocationId, Guid toLocaitonId, int statusId, int transactionTypeId, decimal quantity, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        TaskListId = taskListId;
        StockId = stockId;
        FromLocationId = fromLocationId;
        ToLocaitonId = toLocaitonId;
        StatusId = statusId;
        TransactionTypeId = transactionTypeId;
        Quantity = quantity;
        DepositorId = depositorId;
    }
}
