namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

public class UpdateLocationProductAttributeSubDto
{
    public Guid ProductId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
