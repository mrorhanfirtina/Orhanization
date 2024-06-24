using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;

public class CreatedItemUnitConversionResponse
{
    public Guid Id { get; set; }
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public ItemUnitConversionReferenceItemUnitResponseDto? ReferenceItemUnit { get; set; }
    public ItemUnitConversionConvertedItemUnitResponseDto? ConvertedItemUnit { get; set; }

}

