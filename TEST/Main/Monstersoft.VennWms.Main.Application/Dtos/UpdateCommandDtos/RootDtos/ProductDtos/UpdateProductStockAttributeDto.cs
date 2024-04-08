namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

public class UpdateProductStockAttributeDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
}

