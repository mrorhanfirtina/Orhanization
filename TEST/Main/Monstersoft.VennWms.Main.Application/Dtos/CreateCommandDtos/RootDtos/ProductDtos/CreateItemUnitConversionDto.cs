namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateItemUnitConversionDto
{
    public Guid ReferenceItemUnitId { get; set; }
    public Guid ConvertedItemUnitId { get; set; }
    public decimal ConversionQuantity { get; set; }
}

