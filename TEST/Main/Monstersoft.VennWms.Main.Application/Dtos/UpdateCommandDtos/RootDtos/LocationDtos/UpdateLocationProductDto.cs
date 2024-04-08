namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationProductDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
}

