namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;

public class CreatedShipmentAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }

}
