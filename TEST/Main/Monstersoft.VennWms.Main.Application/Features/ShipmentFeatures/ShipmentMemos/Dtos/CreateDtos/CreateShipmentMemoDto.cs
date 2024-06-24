namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.CreateDtos;

public class CreateShipmentMemoDto
{
    public Guid ShipmentId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

