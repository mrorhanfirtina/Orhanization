namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
    public ProductStockAttributeResponseDto? StockAttribute { get; set; }
}
