using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

public class UpdateStockDto
{
    public Guid Id { get; set; }
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public decimal Quantity { get; set; }
    public decimal FreeQuantity { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReturnId { get; set; }
    public UpdateStockContainerSubDto StockContainer { get; set; }
    public ICollection<UpdateStockAttributeValueSubDto> StockAttributeValues { get; set; }
    public ICollection<UpdateStockMemoSubDto> StockMemos { get; set; }
    public ICollection<UpdateStockReserveReasonSubDto> StockReserveReasons { get; set; }
    public ICollection<UpdateStockUnsuitReasonSubDto> StockUnsuitReasons { get; set; }
}

