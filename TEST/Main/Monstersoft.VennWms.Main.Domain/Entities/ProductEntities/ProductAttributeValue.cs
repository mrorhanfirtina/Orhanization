using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductAttributeValue : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public virtual ProductAttribute ProductAttribute { get; set; }
    public virtual Product Product { get; set; }

    public ProductAttributeValue()
    {
    }

    public ProductAttributeValue(Guid id, Guid productId, Guid productAttributeId, string value) : this()
    {
        Id = id;
        ProductId = productId;
        ProductAttributeId = productAttributeId;
        Value = value;
    }
}
