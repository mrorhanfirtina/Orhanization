namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.ResponseDtos;

public class LocationStockAttributeStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public LocationStockAttributeAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
