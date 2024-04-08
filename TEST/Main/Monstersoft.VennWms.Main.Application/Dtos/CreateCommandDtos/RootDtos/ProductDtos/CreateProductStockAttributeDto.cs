namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateProductStockAttributeDto
{
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
}

