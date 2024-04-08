using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TaskList : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual ICollection<WorkTask> WorkTasks { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public TaskList()
    {
        WorkTasks = new HashSet<WorkTask>();
    }

    public TaskList(Guid id, string code, Guid depositorId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
    }
}
