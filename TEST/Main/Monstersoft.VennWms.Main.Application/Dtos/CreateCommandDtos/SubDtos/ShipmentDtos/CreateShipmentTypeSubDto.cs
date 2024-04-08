namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

public class CreateShipmentTypeSubDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<CreateShipmentSubDto>? Shipments { get; set; }

}

