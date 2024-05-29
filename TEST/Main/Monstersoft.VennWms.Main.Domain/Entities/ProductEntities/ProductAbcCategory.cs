using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductAbcCategory : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public int AbcCategoryId { get; set; }
    public virtual AbcCategoryList? AbcCategory { get; set; }
    public virtual Product? Product { get; set; }

    public ProductAbcCategory()
    {
    }

    public ProductAbcCategory(Guid id, Guid productId, int abcCategoryId) : this()
    {
        Id = id;
        ProductId = productId;
        AbcCategoryId = abcCategoryId;
    }
}
