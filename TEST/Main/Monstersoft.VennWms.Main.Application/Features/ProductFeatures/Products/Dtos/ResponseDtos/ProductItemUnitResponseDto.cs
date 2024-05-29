namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ICollection<ProductItemPackTypeResponseDto>? ItemPackTypes { get; set; }
    public ICollection<ProductItemUnitConversionResponseDto>? ItemUnitConversions { get; set; }
    public ProductUnitResponseDto? Unit { get; set; }
}
