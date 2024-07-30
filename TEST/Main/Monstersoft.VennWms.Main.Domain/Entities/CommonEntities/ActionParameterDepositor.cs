using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ActionParameterDepositor : Entity<Guid>
{
    public int ActionParameterId { get; set; }
    public Guid DepositorId { get; set; }
    public string Value { get; set; }
    public ActionParameter? ActionParameter { get; set; }
    public Depositor? Depositor { get; set; }

    public ActionParameterDepositor()
    {
    }

    public ActionParameterDepositor(int actionParameterId, Guid depositorId, string value) : this()
    {
        ActionParameterId = actionParameterId;
        DepositorId = depositorId;
        Value = value;
    }
}
