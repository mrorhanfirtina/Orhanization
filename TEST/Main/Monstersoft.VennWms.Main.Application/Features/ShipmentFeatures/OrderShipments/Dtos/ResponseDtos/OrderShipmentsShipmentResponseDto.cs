namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.ResponseDtos;

public class OrderShipmentsShipmentResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid DistributorId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
}