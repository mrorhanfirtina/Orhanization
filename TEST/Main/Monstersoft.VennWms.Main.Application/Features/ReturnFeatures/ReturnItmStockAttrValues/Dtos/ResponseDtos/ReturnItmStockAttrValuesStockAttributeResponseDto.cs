namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.ResponseDtos;

public class ReturnItmStockAttrValuesStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public ReturnItmStockAttrValuesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}