namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;

public class UpdatedStockInboundResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
