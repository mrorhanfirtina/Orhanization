using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TaskList : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<WorkTask> WorkTasks { get; set; }

    public TaskList()
    {
        WorkTasks = new HashSet<WorkTask>();
    }

    public TaskList(Guid id, string code, Guid depositorId):this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
    }
}
