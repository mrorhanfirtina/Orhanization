namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

public class CreateLocationCoordinateSubDto
{
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
