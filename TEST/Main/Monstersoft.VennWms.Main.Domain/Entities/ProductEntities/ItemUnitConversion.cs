using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ItemUnitConversion : Entity<Guid>
{
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public virtual ItemUnit ReferenceItemUnit { get; set; }
    public virtual ItemUnit ConvertedItemUnit { get; set; }

    public ItemUnitConversion()
    {
    }

    public ItemUnitConversion(Guid referenceItemUnitId, Guid convertedItemUnitId, decimal conversionQuantity) : this()
    {
        ReferenceItemUnitId = referenceItemUnitId;
        ConvertedItemUnitId = convertedItemUnitId;
        ConversionQuantity = conversionQuantity;
    }
}
