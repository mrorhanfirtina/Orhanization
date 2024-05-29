using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetListByDynamic;

public class GetListByDynamicItemUnitListItemDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ItemUnitProductResponseDto? Product { get; set; }
    public ItemUnitUnitResponseDto? Unit { get; set; }
    public ICollection<ItemUnitItemPackTypeResponseDto>? ItemPackTypes { get; set; }
    public ICollection<ItemUnitItemUnitConversionResponseDto>? ItemUnitConversions { get; set; }

}
