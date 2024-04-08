namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;

public class UpdatedItemUnitConversionResponse
{
    public Guid Id { get; set; }
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

