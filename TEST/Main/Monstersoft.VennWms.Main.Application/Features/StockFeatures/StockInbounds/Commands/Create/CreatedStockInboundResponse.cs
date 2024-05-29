namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;

public class CreatedStockInboundResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public DateTime CreatedDate { get; set; }
}
