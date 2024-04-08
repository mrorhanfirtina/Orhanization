using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;

public class UpdatedShipmentTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<Shipment> Shipments { get; set; }

}

