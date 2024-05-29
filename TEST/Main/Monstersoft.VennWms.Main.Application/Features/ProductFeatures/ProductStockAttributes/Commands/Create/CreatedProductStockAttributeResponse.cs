using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;

public class CreatedProductStockAttributeResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public ProductStockAttributeProductResponseDto? Product { get; set; }
    public ProductStockAttributeStockAttributeResponseDto? StockAttribute { get; set; }
}

