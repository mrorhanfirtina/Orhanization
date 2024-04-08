using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class ShipmentAttributeValue : Entity<Guid>
{
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }
    public virtual ShipmentAttribute ShipmentAttribute { get; set; }

    public ShipmentAttributeValue()
    {
    }

    public ShipmentAttributeValue(Guid id, Guid shipmentId, Guid shipmentAttributeId, string value) : this()
    {
        Id = id;
        ShipmentId = shipmentId;
        ShipmentAttributeId = shipmentAttributeId;
        Value = value;
    }
}
