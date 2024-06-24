namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.UpdateDtos;

public class UpdateLocationCoordinateDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
