using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;

public class CreatedTransactionLogResponse
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
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<LogStock> LogStocks { get; set; }

}
