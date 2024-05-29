namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.ResponseDtos;

public class ItemUnitConversionReferenceItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ItemUnitConversionUnitResponseDto? Unit { get; set; }
    public ItemUnitConversionProductResponseDto? Product { get; set; }
}
