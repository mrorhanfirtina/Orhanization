using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetListByDynamic;

public class GetListByDynamicTaskStockListItemDto
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public TaskStocksStockResponseDto? Stock { get; set; }
    public TaskStocksWorkTaskResponseDto? WorkTask { get; set; }
}
