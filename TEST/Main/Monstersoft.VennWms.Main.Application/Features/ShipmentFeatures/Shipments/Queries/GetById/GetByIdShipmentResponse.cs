using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;

public class GetByIdShipmentResponse
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
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ShipmentsShipmentTypeResponseDto? ShipmentType { get; set; }
    public ShipmentsDistributorResponseDto? Distributor { get; set; }
    public ShipmentsBranchResponseDto? Branch { get; set; }
    public ICollection<ShipmentsShipmentAttributeValueResponseDto>? ShipmentAttributeValues { get; set; }
    public ICollection<ShipmentsShipmentMemoResponseDto>? ShipmentMemos { get; set; }
    public ICollection<ShipmentsOrderShipmentResponseDto>? OrderShipments { get; set; }
    public ShipmentsDepositorResponseDto Depositor { get; set; }
    public ShipmentsDepositorCompanyResponseDto DepositorCompany { get; set; }
}
