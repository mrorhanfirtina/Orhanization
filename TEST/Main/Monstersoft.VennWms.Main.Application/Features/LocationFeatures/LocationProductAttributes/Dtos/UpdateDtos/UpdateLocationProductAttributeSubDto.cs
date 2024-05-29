namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.UpdateDtos;

public class UpdateLocationProductAttributeSubDto
{
    public Guid ProductId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
