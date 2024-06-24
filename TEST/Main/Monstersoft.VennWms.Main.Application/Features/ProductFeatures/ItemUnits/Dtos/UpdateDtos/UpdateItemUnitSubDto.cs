using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures;

public class UpdateItemUnitSubDto
{
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ICollection<UpdateItemPackTypeSubDto> ItemPackTypes { get; set; }
    public ICollection<UpdateItemUnitConversionSubDto> ItemUnitConversions { get; set; }
}

