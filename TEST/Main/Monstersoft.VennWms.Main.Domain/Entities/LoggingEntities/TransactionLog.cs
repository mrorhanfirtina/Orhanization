using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class TransactionLog : Entity<Guid>
{
    public DateTime LogDateTime { get; set; }
    public int UserId { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? OrderItemId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid? ReturnItemId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReceiptItemId { get; set; }
    public Guid? WorkTaskId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual User? User { get; set; }
    public virtual ICollection<LogStock>? LogStocks { get; set; }

    public TransactionLog()
    {
        LogStocks = new HashSet<LogStock>();
    }

    public TransactionLog(Guid id, DateTime logDateTime, int userId, Guid depositorId, Guid depositorCompanyId) : this()
    {
        Id = id;
        LogDateTime = logDateTime;
        UserId = userId;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
    }
}
