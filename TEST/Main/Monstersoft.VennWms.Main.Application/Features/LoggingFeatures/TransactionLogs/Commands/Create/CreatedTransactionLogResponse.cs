using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;

public class CreatedTransactionLogResponse
{
    public Guid Id { get; set; }
    public DateTime LogDateTime { get; set; }
    public int UserId { get; set; }
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
    public TransactionLogDepositorResponseDto? Depositor { get; set; }
    public TransactionLogDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public TransactionLogUserResponseDto? User { get; set; }
    public ICollection<TransactionLogLogStockResponseDto>? LogStocks { get; set; }

}
