namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.ResponseDtos;

public class ItemUnitConvertedItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ItemUnitUnitResponseDto? Unit { get; set; }
}
