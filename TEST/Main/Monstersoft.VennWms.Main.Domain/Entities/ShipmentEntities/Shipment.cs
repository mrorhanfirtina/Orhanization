using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class Shipment : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DistirbutorId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
    public virtual Disturbitor? Disturbitor { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual ShipmentType? ShipmentType { get; set; }
    public virtual ICollection<ShipmentAttributeValue> ShipmentAttributeValues { get; set; }
    public virtual ICollection<ShipmentMemo> ShipmentMemos { get; set; }

    public Shipment()
    {
        ShipmentAttributeValues = new HashSet<ShipmentAttributeValue>();
        ShipmentMemos = new HashSet<ShipmentMemo>();
    }

    public Shipment(Guid id, string code, Guid depositorId, Guid distirbutorId, Guid branchId, Guid shipmentTypeId, DateTime inputDate) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        DistirbutorId = distirbutorId;
        BranchId = branchId;
        ShipmentTypeId = shipmentTypeId;
        InputDate = inputDate;
    }
}
