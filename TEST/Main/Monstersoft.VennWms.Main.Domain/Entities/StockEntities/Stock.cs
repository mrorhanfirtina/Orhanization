using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class Stock : Entity<Guid>
{
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public virtual StockContainer? StockContainer { get; set; }
    public virtual ICollection<StockAttributeValue>? StockAttributeValues { get; set; }
    public virtual ICollection<StockMemo>? StockMemos { get; set; }
    public virtual ICollection<StockReserveReason>? StockReserveReasons { get; set; }
    public virtual ICollection<StockUnsuitReason>? StockUnsuitReasons { get; set; }
    public virtual ICollection<StockInbound>? StockInbounds { get; set; }
    public virtual ICollection<StockPackType>? StockPackTypes { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Location? Location { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }

    public Stock()
    {
        StockAttributeValues = new HashSet<StockAttributeValue>();
        StockMemos = new HashSet<StockMemo>();
        StockReserveReasons = new HashSet<StockReserveReason>();
        StockUnsuitReasons = new HashSet<StockUnsuitReason>();
        StockInbounds = new HashSet<StockInbound>();
        StockPackTypes = new HashSet<StockPackType>();
    }

    public Stock(Guid id, Guid stockContainerId, Guid productId, Guid depositorId, Guid depositorCompanyId, decimal cuQuantity, decimal cuQuantityFree, Guid locationId, Guid cuItemUnitId) : this()
    {
        Id = id;
        StockContainerId = stockContainerId;
        ProductId = productId;
        DepositorId = depositorId;
        CuItemUnitId = cuItemUnitId;
        CuQuantity = cuQuantity;
        CuQuantityFree = cuQuantityFree;
        LocationId = locationId;
        DepositorCompanyId = depositorCompanyId;
    }
}
