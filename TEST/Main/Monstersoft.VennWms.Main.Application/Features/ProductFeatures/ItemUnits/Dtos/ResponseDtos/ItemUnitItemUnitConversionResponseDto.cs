namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.ResponseDtos;

public class ItemUnitItemUnitConversionResponseDto
{
    public Guid Id { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public ItemUnitUnitResponseDto? ConvertedItemUnit { get; set; }
}
