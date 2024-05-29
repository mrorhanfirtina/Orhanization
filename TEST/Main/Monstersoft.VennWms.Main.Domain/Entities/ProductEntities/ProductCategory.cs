using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductCategory : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public int CategoryId { get; set; }
    public virtual ProductCategoryList? Category { get; set; }
    public virtual Product? Product { get; set; }

    public ProductCategory()
    {
    }

    public ProductCategory(Guid id, Guid productId, int categoryId) : this()
    {
        Id = id;
        ProductId = productId;
        CategoryId = categoryId;
    }
}
