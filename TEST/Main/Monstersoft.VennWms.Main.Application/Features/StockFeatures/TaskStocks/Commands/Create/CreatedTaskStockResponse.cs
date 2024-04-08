namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Create;

public class CreatedTaskStockResponse
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }

}
