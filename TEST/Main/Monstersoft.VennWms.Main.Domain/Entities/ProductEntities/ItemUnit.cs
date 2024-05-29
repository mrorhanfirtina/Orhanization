using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ItemUnit : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public virtual ICollection<ItemPackType>? ItemPackTypes { get; set; }
    public virtual ICollection<ItemUnitConversion>? ItemUnitConversions { get; set; }
    public virtual Unit? Unit { get; set; }
    public virtual Product? Product { get; set; }
    public ItemUnit()
    {
        ItemPackTypes = new HashSet<ItemPackType>();
        ItemUnitConversions = new HashSet<ItemUnitConversion>();
    }

    public ItemUnit(Guid id, Guid productId, int unitId, bool isConsumerUnit) : this()
    {
        Id = id;
        ProductId = productId;
        UnitId = unitId;
        IsConsumerUnit = isConsumerUnit;
    }

}
