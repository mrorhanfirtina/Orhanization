namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.ResponseDtos;

public class LocationProductConstraintItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public LocationProductConstraintProductResponseDto? Product { get; set; }
    public LocationProductConstraintUnitResponseDto? Unit { get; set; }
}
