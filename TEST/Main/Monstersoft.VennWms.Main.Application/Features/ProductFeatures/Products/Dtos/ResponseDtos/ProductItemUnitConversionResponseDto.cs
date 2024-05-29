namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductItemUnitConversionResponseDto
{
    public Guid Id { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public ProductUnitResponseDto? ConvertedItemUnit { get; set; }
}
