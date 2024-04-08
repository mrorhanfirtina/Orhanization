using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetListByDynamic;

public class GetListByDynamicShipmentListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public Guid DisturbitorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Distributor Disturbitor { get; set; }
    public Branch Branch { get; set; }
    public ShipmentType ShipmentType { get; set; }
    public ICollection<ShipmentAttributeValue> ShipmentAttributeValues { get; set; }
    public ICollection<ShipmentMemo> ShipmentMemos { get; set; }
    public ICollection<OrderShipItem> OrderShipItems { get; set; }

}
