namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationCoordinateDto
{
    public Guid LocationId { get; set; }
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
