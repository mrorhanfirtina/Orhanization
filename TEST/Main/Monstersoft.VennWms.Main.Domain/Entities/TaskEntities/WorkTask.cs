using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class WorkTask : Entity<Guid>
{
    public string Code { get; set; }
    public Guid TaskListId { get; set; }
    public Guid StockId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocationId { get; set; }
    public int StatusId { get; set; }
    public int TransactionTypeId { get; set; }
    public decimal Quantity { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual Stock Stock { get; set; }
    public virtual Location FromLocation { get; set; }
    public virtual Location ToLocation { get; set; }
    public virtual Status Status { get; set; }
    public virtual TransactionType TransactionType { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public WorkTask()
    {

    }

    public WorkTask(Guid id, string code, Guid taskListId, Guid stockId, Guid fromLocationId, Guid toLocationId, int statusId, int transactionTypeId, decimal quantity, Guid depositorId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        TaskListId = taskListId;
        StockId = stockId;
        FromLocationId = fromLocationId;
        ToLocationId = toLocationId;
        StatusId = statusId;
        TransactionTypeId = transactionTypeId;
        Quantity = quantity;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
    }
}
