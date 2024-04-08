namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

public class UpdateTaskStockDto
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
}

