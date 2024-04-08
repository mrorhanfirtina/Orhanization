using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class UnsuitReason : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsBlocked { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public UnsuitReason()
    {
    }

    public UnsuitReason(Guid id,string code, string description, Guid depositorCompanyId, bool isBlocked) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorCompanyId = depositorCompanyId;
        IsBlocked = isBlocked;
    }
}
