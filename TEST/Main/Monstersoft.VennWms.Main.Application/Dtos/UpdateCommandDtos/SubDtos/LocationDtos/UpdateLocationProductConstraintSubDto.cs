namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

public class UpdateLocationProductConstraintSubDto
{
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
}
