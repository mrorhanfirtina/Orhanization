using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class Status : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<WorkTask> WorkTasks { get; set; }

    public Status()
    {
        Orders = new HashSet<Order>();
        WorkTasks = new HashSet<WorkTask>();
    }

    public Status(int id, string code, string description) : this()
    {
        Id = id;
        Code = code;
        Description = description;
    }
}
