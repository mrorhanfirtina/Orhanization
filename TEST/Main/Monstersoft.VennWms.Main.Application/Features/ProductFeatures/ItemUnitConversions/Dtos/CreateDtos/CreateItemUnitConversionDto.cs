namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.CreateDtos;

public class CreateItemUnitConversionDto
{
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
}

