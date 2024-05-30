using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;

public class CreatedStockMemoResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public StockMemosStockResponseDto? Stock { get; set; }
}
