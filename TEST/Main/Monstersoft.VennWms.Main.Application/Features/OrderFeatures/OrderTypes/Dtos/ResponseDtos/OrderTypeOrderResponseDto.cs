namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.ResponseDtos;

public class OrderTypeOrderResponseDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public int StatusId { get; set; }
    public OrderTypeCustomerResponseDto? Customer { get; set; }
    public OrderTypeDepositorResponseDto? Depositor { get; set; }
    public OrderTypeReceiverResponseDto? Receiver { get; set; }
}
