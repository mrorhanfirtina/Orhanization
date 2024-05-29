using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.POEntities;

public class PoAttributeValue : Entity<Guid>
{
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
    public virtual PoAttribute PoAttribute { get; set; }
    public virtual PurchaseOrder PurchaseOrder { get; set; }

    public PoAttributeValue()
    {
    }

    public PoAttributeValue(Guid id, Guid purchaseOrderId, Guid poAttributeId, string value) : this()
    {
        Id = id;
        PurchaseOrderId = purchaseOrderId;
        PoAttributeId = poAttributeId;
        Value = value;
    }
}
