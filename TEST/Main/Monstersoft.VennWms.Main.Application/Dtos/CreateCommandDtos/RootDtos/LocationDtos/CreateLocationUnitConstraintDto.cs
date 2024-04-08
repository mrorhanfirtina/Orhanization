namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationUnitConstraintDto
{
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
}
