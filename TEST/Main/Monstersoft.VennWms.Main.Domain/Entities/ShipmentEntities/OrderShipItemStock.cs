using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipItemStock : Entity<Guid>
{
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public virtual OrderShipItem? OrderShipItem { get; set; }
    public virtual OrderShipItemTask? OrderShipItemTask { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual StockPackType? StockPackType { get; set; }

    public OrderShipItemStock()
    {
    }

    public OrderShipItemStock(Guid id, Guid orderShipItemId, Guid orderShipItemTaskId, Guid stockId, Guid stockPackTypeId, decimal quantity) : this()
    {
        Id = id;
        OrderShipItemId = orderShipItemId;
        OrderShipItemTaskId = orderShipItemTaskId;
        StockId = stockId;
        Quantity = quantity;
        StockPackTypeId = stockPackTypeId;
    }
}
