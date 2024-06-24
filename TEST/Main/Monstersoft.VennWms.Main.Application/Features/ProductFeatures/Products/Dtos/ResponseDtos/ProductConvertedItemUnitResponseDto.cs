namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductConvertedItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ProductUnitResponseDto? Unit { get; set; }
}
