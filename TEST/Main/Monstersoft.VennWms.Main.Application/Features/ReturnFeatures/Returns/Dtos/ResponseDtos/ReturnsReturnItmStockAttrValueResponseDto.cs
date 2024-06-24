namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsReturnItmStockAttrValueResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public ReturnsStockAttributeResponseDto? StockAttribute { get; set; }
}