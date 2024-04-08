using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductStockAttribute : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
    public virtual StockAttribute StockAttribute { get; set; }

    public ProductStockAttribute()
    {
    }

    public ProductStockAttribute(Guid id, Guid productId, Guid stockAttributeId, bool isNecessary)
    {
        Id = id;
        ProductId = productId;
        StockAttributeId = stockAttributeId;
        IsNecessary = isNecessary;
    }
}

