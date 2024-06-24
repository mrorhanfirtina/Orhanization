namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationUnitConstraintResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public virtual LocationUnitResponseDto? Unit { get; set; }
}
