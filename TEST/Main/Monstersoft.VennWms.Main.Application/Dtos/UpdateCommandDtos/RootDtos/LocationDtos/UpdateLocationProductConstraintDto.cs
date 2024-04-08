namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationProductConstraintDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
