namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.CreateDtos;

public class CreateLocationProductAttributeSubDto
{
    public Guid ProductId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
