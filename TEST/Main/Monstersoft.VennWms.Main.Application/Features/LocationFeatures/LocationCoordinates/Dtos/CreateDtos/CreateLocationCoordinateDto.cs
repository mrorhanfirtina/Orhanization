namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.CreateDtos;

public class CreateLocationCoordinateDto
{
    public Guid LocationId { get; set; }
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
}
