namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetById;

public class GetByIdTaskStockResponse
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
