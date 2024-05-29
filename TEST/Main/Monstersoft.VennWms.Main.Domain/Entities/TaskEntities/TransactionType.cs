using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TransactionType : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsLogging { get; set; }
    public bool IsTaskType { get; set; }
    public bool IsOperational { get; set; }

    public TransactionType()
    {
    }

    public TransactionType(int id, string code, string description, bool isLogging, bool isTaskType, bool isOperational) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        IsLogging = isLogging;
        IsTaskType = isTaskType;
        IsOperational = isOperational;
    }
}
