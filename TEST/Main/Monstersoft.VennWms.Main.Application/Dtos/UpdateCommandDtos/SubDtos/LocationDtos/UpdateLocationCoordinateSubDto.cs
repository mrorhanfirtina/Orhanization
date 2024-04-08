namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

public class UpdateLocationCoordinateSubDto
{
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
