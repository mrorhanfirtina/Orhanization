using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipment : Entity<Guid>
{
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime? LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public virtual Order? Order { get; set; }
    public virtual ProgressStatus? ProgressStatus { get; set; }

    public OrderShipment()
    {
        
    }

    public OrderShipment(Guid id, string code, Guid orderId, Guid shipmentId, int progressStatusId) : this()
    {
        Id = id;
        Code = code;
        OrderId = orderId;
        ShipmentId = shipmentId;
        ProgressStatusId = progressStatusId;
    }
}
