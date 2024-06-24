using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipment : Entity<Guid>
{
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime? LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public virtual Order? Order { get; set; }
    public virtual ICollection<OrderShipItem>? OrderShipItems { get; set; }
    public virtual Shipment? Shipment { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual ProgressStatus? ProgressStatus { get; set; }


    public OrderShipment()
    {
        OrderShipItems = new HashSet<OrderShipItem>();
    }

    public OrderShipment(Guid id, string code, Guid orderId, Guid shipmentId, Guid depositorCompanyId, int progressStatusId) : this()
    {
        Id = id;
        Code = code;
        OrderId = orderId;
        ShipmentId = shipmentId;
        ProgressStatusId = progressStatusId;
        DepositorCompanyId = depositorCompanyId;
    }
}
