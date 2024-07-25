namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.ResponseDtos;

public class SerialLogTransactionLogResponseDto
{
    public Guid Id { get; set; }
    public DateTime LogDateTime { get; set; }
    public int UserId { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? OrderItemId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid? ReturnItemId { get; set; }
    public Guid? ReceiptItemId { get; set; }
    public Guid? WorkTaskId { get; set; }
}
