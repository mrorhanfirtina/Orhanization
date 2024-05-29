using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class PriorityList : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public PriorityList()
    {
    }

    public PriorityList(int id, string code, string description, int priority) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        Priority = priority;
    }
}
