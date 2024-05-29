using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures;

public class UpdateShipmentTypeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public ICollection<UpdateShipmentSubDto> Shipments { get; set; }
}

