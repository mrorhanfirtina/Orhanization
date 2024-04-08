namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;

public class CreateTaskStockDto
{
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
}

