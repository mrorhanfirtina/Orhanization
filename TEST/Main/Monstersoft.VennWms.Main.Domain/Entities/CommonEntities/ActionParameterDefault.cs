using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ActionParameterDefault : Entity<Guid>
{
    public int ActionParameterId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Value { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual ActionParameter? ActionParameter { get; set; }

    public ActionParameterDefault()
    {
    }

    public ActionParameterDefault(int actionParameterId, Guid depositorCompanyId, string value) : this()
    {
        ActionParameterId = actionParameterId;
        DepositorCompanyId = depositorCompanyId;
        Value = value;
    }
}
