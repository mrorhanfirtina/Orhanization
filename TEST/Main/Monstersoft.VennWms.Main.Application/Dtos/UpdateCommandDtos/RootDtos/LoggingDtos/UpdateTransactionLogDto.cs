using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateTransactionLogDto
{
    public Guid Id { get; set; }
    public DateTime LogDateTime { get; set; }
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ReturnItemId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<UpdateLogStockSubDto> LogStocks { get; set; }
}

