using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetById;

public class GetByIdOrderShipmentResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<OrderShipItem> OrderShipItems { get; set; }

}
