using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class Stock : Entity<Guid>
{
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal Quantity { get; set; }
    public decimal FreeQuantity { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public virtual StockContainer? StockContainer { get; set; }
    public virtual ICollection<StockAttributeValue> StockAttributeValues { get; set; }
    public virtual ICollection<StockMemo> StockMemos { get; set; }
    public virtual ICollection<StockReserveReason> StockReserveReasons { get; set; }
    public virtual ICollection<StockUnsuitReason> StockUnsuitReasons { get; set; }
    public virtual Product Product { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual Location Location { get; set; }
    public virtual Unit Unit { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual Return? Return { get; set; }

    public Stock()
    {
        StockAttributeValues = new HashSet<StockAttributeValue>();
        StockMemos = new HashSet<StockMemo>();
        StockReserveReasons = new HashSet<StockReserveReason>();
        StockUnsuitReasons = new HashSet<StockUnsuitReason>();
    }

    public Stock(Guid id, Guid stockContainerId, Guid productId, Guid depositorId, Guid depositorCompanyId, decimal quantity, decimal freeQuantity, Guid locationId, int unitId) : this()
    {
        Id = id;
        StockContainerId = stockContainerId;
        ProductId = productId;
        DepositorId = depositorId;
        Quantity = quantity;
        FreeQuantity = freeQuantity;
        LocationId = locationId;
        UnitId = unitId;
        DepositorCompanyId = depositorCompanyId;
    }
}
