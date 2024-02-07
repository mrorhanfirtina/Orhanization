using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ProgressStatus : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public virtual ICollection<OrderShipItem> OrderShipItems { get; set; }
    public virtual ICollection<OrderShipment> OrderShipments { get; set; }

    public ProgressStatus()
    {
        OrderShipItems = new HashSet<OrderShipItem>();
        OrderShipments = new HashSet<OrderShipment>();
    }

    public ProgressStatus(int id, string code, string description) : this()
    {
        Id = id;
        Code = code;
        Description = description;
    }
}
