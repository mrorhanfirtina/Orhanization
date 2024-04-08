namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;

public class UpdatedStockMemoResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
