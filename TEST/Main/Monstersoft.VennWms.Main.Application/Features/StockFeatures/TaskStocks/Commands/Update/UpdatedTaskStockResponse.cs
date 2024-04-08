namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;

public class UpdatedTaskStockResponse
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
