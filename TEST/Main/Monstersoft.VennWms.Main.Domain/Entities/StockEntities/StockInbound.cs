using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockInbound : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual Receipt? Receipt { get; set; }    
    public virtual Return? Return { get; set; }
    public virtual ItemUnit? CuItemUnit { get; set; }

    public StockInbound()
    {
    }

    public StockInbound(Guid id, Guid stockId, Guid? receiptId, Guid? returnId, Guid cuItemUnitId, decimal cuQuantity, decimal cuQuantityFree) : this()
    {
        Id = id;
        StockId = stockId;
        ReceiptId = receiptId;
        ReturnId = returnId;
        CuItemUnitId = cuItemUnitId;
        CuQuantity = cuQuantity;
        CuQuantityFree = cuQuantityFree;
    }
}
