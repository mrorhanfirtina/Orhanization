using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnItem : Entity<Guid>
{
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public virtual ICollection<ReturnItemMemo> ReturnItemMemos { get; set; }
    public virtual ICollection<ReturnItmStockAttrValue> ReturnItmStockAttrValues { get; set; }
    public virtual Product Product { get; set; }
    public virtual ItemUnit ItemUnit { get; set; }
    public virtual Status Status { get; set; }

    public ReturnItem()
    {
        ReturnItemMemos = new HashSet<ReturnItemMemo>();
        ReturnItmStockAttrValues = new HashSet<ReturnItmStockAttrValue>();
    }

    public ReturnItem(Guid id, Guid returnId, Guid productId, Guid itemUnitId, decimal expectedQuantity, decimal actualQuantity, int statusId) : this()
    {
        Id = id;
        ReturnId = returnId;
        ProductId = productId;
        ItemUnitId = itemUnitId;
        ExpectedQuantity = expectedQuantity;
        ActualQuantity = actualQuantity;
        StatusId = statusId;
    }
}
