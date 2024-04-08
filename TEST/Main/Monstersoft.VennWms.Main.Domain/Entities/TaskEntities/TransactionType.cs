using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TransactionType : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsLogging { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public TransactionType()
    {
    }

    public TransactionType(int id, string code, string description, bool isLogging,Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        IsLogging = isLogging;
        DepositorCompanyId = depositorCompanyId;
    }
}
