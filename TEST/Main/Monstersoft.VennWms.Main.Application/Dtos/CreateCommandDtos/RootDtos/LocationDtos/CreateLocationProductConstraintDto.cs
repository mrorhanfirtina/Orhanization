namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationProductConstraintDto
{
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
