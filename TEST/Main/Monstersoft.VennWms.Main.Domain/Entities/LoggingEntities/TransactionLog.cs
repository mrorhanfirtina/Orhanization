using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class TransactionLog : Entity<Guid>
{
    public DateTime LogDateTime { get; set; }
    public Guid UserId { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? WorkTaskId { get; set; }
    public Guid DepositorId { get; set; }
    public virtual Order? Order { get; set; }
    public virtual Return? Return { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual WorkTask? WorkTask { get; set; }
    public virtual ICollection<LogStock> LogStocks { get; set; }

    public TransactionLog()
    {
        LogStocks = new HashSet<LogStock>();
    }

    public TransactionLog(Guid id, DateTime logDateTime, Guid userId, Guid depositorId) : this()
    {
        Id = id;
        LogDateTime = logDateTime;
        UserId = userId;
        DepositorId = depositorId;
    }
}
