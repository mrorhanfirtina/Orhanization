namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.CreateDtos;

public class CreateSerialLogDto
{
    public Guid TransactionLogId { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
}
