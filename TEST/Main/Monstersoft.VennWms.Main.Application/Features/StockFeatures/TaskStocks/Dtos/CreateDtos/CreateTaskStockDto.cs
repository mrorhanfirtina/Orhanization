namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.CreateDtos;

public class CreateTaskStockDto
{
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
}

