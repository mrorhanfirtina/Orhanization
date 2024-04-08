namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetById;

public class GetByIdProductStockAttributeResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

