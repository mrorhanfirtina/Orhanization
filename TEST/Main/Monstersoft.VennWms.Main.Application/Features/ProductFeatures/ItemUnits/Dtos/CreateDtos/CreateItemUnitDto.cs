using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;

public class CreateItemUnitDto
{
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public bool HasSerial { get; set; }
    public ICollection<CreateItemPackTypeSubDto> ItemPackTypes { get; set; }
    public ICollection<CreateItemUnitConversionSubDto> ItemUnitConversions { get; set; }

}

