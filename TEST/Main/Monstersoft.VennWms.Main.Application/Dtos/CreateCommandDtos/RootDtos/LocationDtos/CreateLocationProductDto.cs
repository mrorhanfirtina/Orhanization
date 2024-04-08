namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationProductDto
{
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
}

