using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;

public class CreateStockDto
{
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public decimal Quantity { get; set; }
    public decimal FreeQuantity { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReturnId { get; set; }
    public CreateStockContainerSubDto StockContainer { get; set; }
    public ICollection<CreateStockAttributeValueSubDto> StockAttributeValues { get; set; }
    public ICollection<CreateStockMemoSubDto> StockMemos { get; set; }
    public ICollection<CreateStockReserveReasonSubDto> StockReserveReasons { get; set; }
    public ICollection<CreateStockUnsuitReasonSubDto> StockUnsuitReasons { get; set; }
}

