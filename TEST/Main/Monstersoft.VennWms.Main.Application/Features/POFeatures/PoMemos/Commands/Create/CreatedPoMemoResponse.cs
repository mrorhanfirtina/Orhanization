using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Create;

public class CreatedPoMemoResponse
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public PoMemoPurchaseOrderResponseDto? PurchaseOrder { get; set; }

}
