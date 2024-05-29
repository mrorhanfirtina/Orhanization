using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;

public class UpdatedStockResponse
{
    public Guid Id { get; set; }
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal Quantity { get; set; }
    public decimal FreeQuantity { get; set; }
    public Guid LocationId { get; set; }
    public Guid UnitId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReturnId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockContainer StockContainer { get; set; }
    public ICollection<StockAttributeValue> StockAttributeValues { get; set; }
    public ICollection<StockInbound> StockInbounds { get; set; }
    public ICollection<StockPackType> StockPackTypes { get; set; }
    public ICollection<StockMemo> StockMemos { get; set; }
    public ICollection<StockReserveReason> StockReserveReasons { get; set; }
    public ICollection<StockUnsuitReason> StockUnsuitReasons { get; set; }

}

