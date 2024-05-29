namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.UpdateDtos;

public class UpdateLocationUnitConstraintDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
}
