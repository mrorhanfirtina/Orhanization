namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.ResponseDtos;

public class OrderMemoOrderResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public int StatusId { get; set; }
}
