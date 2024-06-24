using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class LockReason : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public LockReason()
    {
    }

    public LockReason(int id, string code, string description, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorCompanyId = depositorCompanyId;
    }
}
