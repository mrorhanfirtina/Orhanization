namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

public class CreateLocationProductConstraintSubDto
{
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
