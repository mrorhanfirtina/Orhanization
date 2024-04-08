using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TaskCodeFormat : Entity<Guid>
{
    public string Code { get; set; }
    public string TaskFormat { get; set; }
    public int TaskCounter { get; set; }
    public string TaskListFormat { get; set; }
    public int TaskListCounter { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual TransactionType TransactionType { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public TaskCodeFormat()
    {
    }

    public TaskCodeFormat(string code, string taskFormat, int taskCounter, string taskListFormat, int taskListCounter, int transactionTypeId, Guid depositorCompanyId) : this()
    {
        Code = code;
        TaskFormat = taskFormat;
        TaskCounter = taskCounter;
        TaskListFormat = taskListFormat;
        TaskListCounter = taskListCounter;
        TransactionTypeId = transactionTypeId;
        DepositorCompanyId = depositorCompanyId;
    }
}
