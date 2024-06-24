using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.CreateDtos;

public class CreateTransactionLogDto
{
    public int UserId { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? OrderItemId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid? ReturnItemId { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReceiptItemId { get; set; }
    public Guid? WorkTaskId { get; set; }
    public Guid? DepositorId { get; set; }
    public ICollection<CreateLogStockSubDto>? LogStocks { get; set; }
}

