using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockPackType : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Quantity { get; set; }
    public decimal QuantityFree { get; set; }
    public decimal PackTypeRatio { get; set; }
    public decimal CUQuantity { get; set; }
    public decimal CUQuantityFree { get; set; }
    public virtual Stock Stock { get; set; }
    public virtual ItemUnit ItemUnit { get; set; }

    public StockPackType()
    {
    }

    public StockPackType(Guid stockId, Guid itemUnitId, decimal quantity, decimal quantityFree, decimal packTypeRatio, decimal cUQuantity, decimal cUQuantityFree) : this()
    {
        StockId = stockId;
        ItemUnitId = itemUnitId;
        Quantity = quantity;
        QuantityFree = quantityFree;
        PackTypeRatio = packTypeRatio;
        CUQuantity = cUQuantity;
        CUQuantityFree = cUQuantityFree;
    }
}
