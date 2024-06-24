namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;

public class CreateProductStockAttributeDto
{
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
}

