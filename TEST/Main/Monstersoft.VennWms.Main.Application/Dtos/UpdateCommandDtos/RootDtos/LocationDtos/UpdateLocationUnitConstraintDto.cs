namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationUnitConstraintDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
}
