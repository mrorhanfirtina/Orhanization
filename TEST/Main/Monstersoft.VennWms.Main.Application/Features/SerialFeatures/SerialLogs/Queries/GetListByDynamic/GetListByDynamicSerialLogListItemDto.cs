using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetListByDynamic;

public class GetListByDynamicSerialLogListItemDto
{
    public Guid Id { get; set; }
    public Guid TransactionLogId { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public SerialLogTransactionLogResponseDto? TransactionLog { get; set; }
    public SerialLogTransactionTypeResponseDto? TransactionType { get; set; }
    public SerialLogDepositorResponseDto? Depositor { get; set; }
    public SerialLogDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public SerialLogReceiptResponseDto? Receipt { get; set; }
}
