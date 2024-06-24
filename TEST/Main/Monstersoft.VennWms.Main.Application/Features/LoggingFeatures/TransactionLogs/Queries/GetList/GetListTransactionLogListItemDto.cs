using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetList;

public class GetListTransactionLogListItemDto
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
    public DateTime UpdatedDate { get; set; }
    public TransactionLogDepositorResponseDto? Depositor { get; set; }
    public TransactionLogDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public TransactionLogUserResponseDto? User { get; set; }
    public ICollection<TransactionLogLogStockResponseDto>? LogStocks { get; set; }
}
