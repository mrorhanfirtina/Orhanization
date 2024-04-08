namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationProductAttributeDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}

