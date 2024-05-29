namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.CreateDtos;

public class CreateLocationProductConstraintDto
{
    public Guid LocationId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
