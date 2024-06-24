using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class Shipment : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid DistributorId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
    public virtual ShipmentType? ShipmentType { get; set; }
    public virtual Distributor? Distributor { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual ICollection<ShipmentAttributeValue>? ShipmentAttributeValues { get; set; }
    public virtual ICollection<ShipmentMemo>? ShipmentMemos { get; set; }
    public virtual ICollection<OrderShipment>? OrderShipments { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public Shipment()
    {
        ShipmentAttributeValues = new HashSet<ShipmentAttributeValue>();
        ShipmentMemos = new HashSet<ShipmentMemo>();
        OrderShipments = new HashSet<OrderShipment>();
    }

    public Shipment(Guid id, string code, Guid depositorId, Guid depositorCompanyId, Guid distributorId, Guid branchId, Guid shipmentTypeId, DateTime inputDate) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        DistributorId = distributorId;
        BranchId = branchId;
        ShipmentTypeId = shipmentTypeId;
        InputDate = inputDate;
        DepositorCompanyId = depositorCompanyId;
    }
}
