using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Depositor : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual DepositorFeature DepositorFeature { get; set; }
    public Depositor()
    {

    }

    public Depositor(Guid id, string code, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        DepositorCompanyId = depositorCompanyId;
    }
}
