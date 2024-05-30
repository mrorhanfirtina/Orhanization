namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.ResponseDtos;

public class StockAttributeValuesStockAttributeResponseDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public StockAttributeValuesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}