using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetListByDynamic;

public class GetListByDynamicPoMemoListItemDto
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PoMemoPurchaseOrderResponseDto? PurchaseOrder { get; set; }

}
