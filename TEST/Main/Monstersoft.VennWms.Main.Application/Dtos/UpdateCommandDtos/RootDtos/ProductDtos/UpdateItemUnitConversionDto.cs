namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

public class UpdateItemUnitConversionDto
{
    public Guid Id { get; set; }
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
}

