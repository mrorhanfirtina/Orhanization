using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetByCode;

public class GetByCodeShipmentAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ShipmentAttributesDepositorCompanyResponseDto DepositorCompany { get; set; }
    public ShipmentAttributesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
