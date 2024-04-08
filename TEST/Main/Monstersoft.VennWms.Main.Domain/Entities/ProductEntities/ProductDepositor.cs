using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductDepositor : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public virtual Depositor Depositor { get; set; }

    public ProductDepositor()
    {
    }

    public ProductDepositor(Guid id, Guid productId, Guid depositorId) : this()
    {
        Id = id;
        ProductId = productId;
        DepositorId = depositorId;
    }
}

