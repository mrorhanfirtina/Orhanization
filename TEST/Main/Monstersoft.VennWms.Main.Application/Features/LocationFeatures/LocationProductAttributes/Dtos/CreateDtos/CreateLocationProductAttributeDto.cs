namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.CreateDtos;

public class CreateLocationProductAttributeDto
{
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}

