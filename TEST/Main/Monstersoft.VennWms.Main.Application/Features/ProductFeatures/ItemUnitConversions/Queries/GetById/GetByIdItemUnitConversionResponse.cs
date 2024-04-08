namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;

public class GetByIdItemUnitConversionResponse
{
    public Guid Id { get; set; }
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

