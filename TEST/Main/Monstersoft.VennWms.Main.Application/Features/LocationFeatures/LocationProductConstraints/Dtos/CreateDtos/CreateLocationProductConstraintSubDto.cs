namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.CreateDtos;

public class CreateLocationProductConstraintSubDto
{
    public Guid ItemUnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
