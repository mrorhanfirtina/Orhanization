namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationCoordinateDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
