using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetById;

public class GetByIdOrderShipItemStockResponse
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderShipItemTask OrderShipItemTask { get; set; }

}

