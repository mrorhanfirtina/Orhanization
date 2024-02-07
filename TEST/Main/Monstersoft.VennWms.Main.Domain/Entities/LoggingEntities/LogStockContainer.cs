using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockContainer : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid FromContainerId { get; set; }
    public Guid ToContainerId { get; set; }
    public string FromContainerSSCC { get; set; }
    public string ToContainerSSCC { get; set; }
    public virtual LogStock? LogStock { get; set; }

    public LogStockContainer()
    {
    }

    public LogStockContainer(Guid id, Guid logStockId, Guid fromContainerId, Guid toContainerId, string fromContainerSSCC, string toContainerSSCC) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromContainerId = fromContainerId;
        ToContainerId = toContainerId;
        FromContainerSSCC = fromContainerSSCC;
        ToContainerSSCC = toContainerSSCC;
    }
}
