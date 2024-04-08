using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;

public class UpdatedOrderShipItemResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderItem OrderItem { get; set; }
    public ICollection<OrderShipItemTask> OrderShipItemTasks { get; set; }

}
