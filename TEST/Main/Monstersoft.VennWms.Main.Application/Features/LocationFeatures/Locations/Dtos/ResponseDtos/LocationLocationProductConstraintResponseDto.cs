namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationProductConstraintResponseDto
{
    public Guid Id { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
    public virtual LocationItemUnitResponseDto? ItemUnit { get; set; }
}
