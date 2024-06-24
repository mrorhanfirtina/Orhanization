using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.ResponseDtos;

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
    public StockInboundsStockResponseDto? Stock { get; set; }
    public StockInboundsReceiptResponseDto? Receipt { get; set; }
    public StockInboundsReturnResponseDto? Return { get; set; }
    public StockInboundsItemUnitResponseDto? CuItemUnit { get; set; }
}
