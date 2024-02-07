using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class TaskStock : Entity<Guid>
{
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public virtual Stock? Stock { get; set; }

    public TaskStock()
    {
    }

    public TaskStock(Guid id, Guid workTaskId, Guid stockId, decimal quantity) : this()
    {
        Id = id;
        WorkTaskId = workTaskId;
        StockId = stockId;
        Quantity = quantity;
    }
}
