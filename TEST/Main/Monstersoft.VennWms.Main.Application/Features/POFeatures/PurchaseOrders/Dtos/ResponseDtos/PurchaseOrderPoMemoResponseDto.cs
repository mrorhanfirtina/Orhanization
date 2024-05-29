namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

public class PurchaseOrderPoMemoResponseDto
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
}
